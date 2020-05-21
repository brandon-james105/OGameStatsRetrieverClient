using OGameStatsRetriever.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xml2CSharp;

namespace OGameStatsRetriever
{
    public interface IOGameStatsRetrieverClient
    {
        string Country { get; set; }

        int ServerNumber { get; set; }

        /// <summary>
        /// Binds Country and Server Number into the URI to retrieve the data from.
        /// </summary>
        /// <returns>The server url</returns>
        string ServerUrl();

        /// <summary>
        /// Retrieves a list of short player data from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/players.xml.
        /// Refreshes daily.
        /// </summary>
        /// <returns>A list of players</returns>
        Task<IEnumerable<PlayerBrowseInfo>> GetPlayersAsync();

        /// <summary>
        /// Retrieves alliances from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/alliances.xml.
        /// Refreshes daily.
        /// </summary>
        /// <returns>A list of alliances</returns>
        Task<IEnumerable<Alliance>> GetAlliancesAsync();

        /// <summary>
        /// Retrieves server data from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/serverData.xml.
        /// and returns the server data which shows universe parameters. Refreshes daily.
        /// </summary>
        /// <returns>Server Data</returns>
        Task<ServerData> GetServerDataAsync();

        /// <summary>
        /// Retrieves localization strings from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/localization.xml.
        /// </summary>
        /// <returns>Localization data.</returns>
        Task<Localization> GetLocalizationAsync();

        /// <summary>
        /// Retrieves high scores from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/highscore.xml?category=1&type={highScoreType} for every player.
        /// Refreshes every hour.
        /// </summary>
        /// <param name="highScoreType">Total, Military, Research, Economy, etc.</param>
        /// <returns>A list of the high scores for all players.</returns>
        Task<IEnumerable<PlayerScore>> GetPlayerHighScoresAsync(HighScoreType highScoreType);

        /// <summary>
        /// Retrieves high scores from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/highscore.xml?category=2&type={highScoreType} for every alliance.
        /// Refreshes every hour.
        /// </summary>
        /// <param name="highScoreType">Total, Military, Research, Economy, etc.</param>
        /// <returns>A list of the high scores for all alliances.</returns>
        Task<IEnumerable<AllianceScore>> GetAllianceHighScoresAsync(HighScoreType highScoreType);

        /// <summary>
        /// Retrieves player data from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/playerData.xml?id={playerId}.
        /// Refreshes daily.
        /// </summary>
        /// <param name="playerId">The id of the player you want to retrieve.</param>
        /// <returns>Player data, which includes thier planets.</returns>
        Task<PlayerData> GetPlayerDataAsync(int playerId);

        /// <summary>
        /// Retrieves planets from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/universe.xml.
        /// Refreshes weekly.
        /// </summary>
        /// <returns>A list of planets</returns>
        Task<IEnumerable<Planet>> GetUniverseAsync();

        /// <summary>
        /// Retrieves universes from the endpoint https://s{ServerNumber}-{Country}.ogame.gameforge.com/api/universes.xml.
        /// </summary
        /// <returns>A list of universes.</returns>
        Task<IEnumerable<UniversesListUniverse>> GetUniversesAsync();

        /// <summary>
        /// Retrieves list of servers from a different source than the rest of the data endpoints https://lobby.ogame.gameforge.com/api/servers. Server data includes multipliers.
        /// </summary>
        /// <returns>A list of server data</returns>
        Task<IEnumerable<Server>> GetServersAsync();
    }
}
