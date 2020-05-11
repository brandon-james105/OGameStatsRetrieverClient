using OGameStatsRetrieverClient.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xml2CSharp;

namespace OGameStatsRetriever
{
    public interface IOGameStatsRetrieverClient
    {
        string Country { get; set; }

        int ServerNumber { get; set; }

        string ServerUrl();

        Task<IEnumerable<PlayerBrowseInfo>> GetPlayersAsync();

        Task<IEnumerable<Alliance>> GetAlliancesAsync();

        Task<ServerData> GetServerDataAsync();

        Task<IEnumerable<PlayerScore>> GetPlayerHighScoresAsync(HighScoreType highScoreType);

        Task<IEnumerable<AllianceScore>> GetAllianceHighScoresAsync(HighScoreType highScoreType);

        Task<PlayerData> GetPlayerDataAsync(int playerId);

        Task<Localization> GetLocalizationAsync();

        Task<IEnumerable<Planet>> GetUniverseAsync();

        Task<IEnumerable<UniversesListUniverse>> GetUniversesAsync();
    }
}
