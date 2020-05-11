using OGameStatsRetrieverClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xml2CSharp;

namespace OGameStatsRetriever.Data
{
    public class OGameStatsRetrieverClient : IOGameStatsRetrieverClient
    {
        public string Country { get; set; }

        public int ServerNumber { get; set; }

        public OGameStatsRetrieverClient(string country, int serverNumber)
        {
            Country = country;
            ServerNumber = serverNumber;
        }

        public string ServerUrl()
        {
            return $"https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/";
        }

        private async Task<T> PrepareResourceAsync<T>(string uri)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(ServerUrl())
            };

            var result = await client.GetAsync(uri);
            var resultContentStream = await result.Content.ReadAsStreamAsync();
            var serializer = new XmlSerializer(typeof(T));
            var resource = serializer.Deserialize(resultContentStream);
            return (T)resource;
        }

        private async Task<TChild> GetResourceAsync<TParent, TChild>(string uri, string childPropertyName)
        {
            object resource = await PrepareResourceAsync<TParent>(uri);
            return (TChild)resource.GetType().GetProperty(childPropertyName).GetValue(resource, null);
        }

        private async Task<T> GetResourceAsync<T>(string uri)
        {
            return await PrepareResourceAsync<T>(uri);
        }

        public async Task<IEnumerable<Alliance>> GetAlliancesAsync()
        {
            return await GetResourceAsync<Alliances, List<Alliance>>("alliances.xml", "Alliance");
        }

        public async Task<ServerData> GetServerDataAsync()
        {
            return await GetResourceAsync<ServerData>($"serverData.xml");
        }

        public async Task<Localization> GetLocalizationAsync()
        {
            return await GetResourceAsync<Localization>("localization.xml");
        }

        public async Task<IEnumerable<PlayerBrowseInfo>> GetPlayersAsync()
        {
            return await GetResourceAsync<Players, List<PlayerBrowseInfo>>("players.xml", "Player");
        }

        public async Task<IEnumerable<Planet>> GetUniverseAsync()
        {
            return await GetResourceAsync<Universe, List<Planet>>("universe.xml", "Planet");
        }

        public async Task<IEnumerable<UniversesListUniverse>> GetUniversesAsync()
        {
            return await GetResourceAsync<Universes, List<UniversesListUniverse>>("universes.xml", "Universe");
        }

        public async Task<PlayerData> GetPlayerDataAsync(int playerId)
        {
            return await GetResourceAsync<PlayerData>($"playerData.xml?id={playerId}");
        }

        public async Task<IEnumerable<PlayerScore>> GetPlayerHighScoresAsync(HighScoreType highScoreType)
        {
            return await GetResourceAsync<PlayerHighscore, List<PlayerScore>>($"highscore.xml?category={(int)HighScoreCategory.Player}&type={(int)highScoreType}", "Player");
        }

        public async Task<IEnumerable<AllianceScore>> GetAllianceHighScoresAsync(HighScoreType highScoreType)
        {
            return await GetResourceAsync<AllianceHighscore, List<AllianceScore>>($"highscore.xml?category={(int)HighScoreCategory.Alliance}&type={(int)highScoreType}", "Alliance");
        }
    }
}
