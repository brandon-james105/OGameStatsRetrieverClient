# OGameStatsRetrieverClient
Client to get public data from GameForge's OGame

# Usage and API
The library includes an inteface, `IOGameStatsRetrieverClient` in case you wish to do something custom to your responses in your application.

## Usage

This client is asynchronous and retrieves the data from the requested server, then deserializes it to a POCO. Provide a server country/language and a number to it and it will retrieve data for that server.

```
var client = new OGameStatsRetrieverClient("en", 1); // "en" is the country/language and 1 is the server number
await client.GetAlliancesAsync();
```

## API

The IOGameStatsRetrieverClient retrieves alliance data, high scores, players, universes, servers, and localization data.

### Alliances

Alliance High Scores

`GetAllianceHighScoresAsync(HighScoreType highScoreType)`

Alliance List

`GetAlliancesAsync()`

Localization Data

`GetLocalizationAsync()`

Player Data, including planets and moons

`GetPlayerDataAsync(int playerId)`

Player High Scores

`GetPlayerHighScoresAsync(HighScoreType highScoreType)`

Player List

`GetPlayersAsync()`

Server Data

`GetServerDataAsync()`

Server List

`GetServersAsync()`

Planet List

`GetUniverseAsync()`

Universes

`GetUniversesAsync()`
