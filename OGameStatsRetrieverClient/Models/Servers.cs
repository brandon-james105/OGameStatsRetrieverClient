using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OGameStatsRetriever.Models
{
    public partial class Server
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playerCount")]
        public long PlayerCount { get; set; }

        [JsonProperty("playersOnline")]
        public long PlayersOnline { get; set; }

        [JsonProperty("opened")]
        public string Opened { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public object EndDate { get; set; }

        [JsonProperty("serverClosed")]
        public long ServerClosed { get; set; }

        [JsonProperty("prefered")]
        public long Prefered { get; set; }

        [JsonProperty("signupClosed")]
        public long SignupClosed { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }
    }

    public partial class Settings
    {
        [JsonProperty("aks")]
        public long Aks { get; set; }

        [JsonProperty("fleetSpeed")]
        public long FleetSpeed { get; set; }

        [JsonProperty("wreckField")]
        public long WreckField { get; set; }

        [JsonProperty("serverLabel")]
        public ServerLabel ServerLabel { get; set; }

        [JsonProperty("economySpeed")]
        public long EconomySpeed { get; set; }

        [JsonProperty("planetFields")]
        public long PlanetFields { get; set; }

        [JsonProperty("universeSize")]
        public long UniverseSize { get; set; }

        [JsonProperty("serverCategory")]
        public ServerCategory ServerCategory { get; set; }

        [JsonProperty("espionageProbeRaids")]
        public long EspionageProbeRaids { get; set; }

        [JsonProperty("premiumValidationGift")]
        public long PremiumValidationGift { get; set; }

        [JsonProperty("debrisFieldFactorShips")]
        public long DebrisFieldFactorShips { get; set; }

        [JsonProperty("debrisFieldFactorDefence")]
        public long DebrisFieldFactorDefence { get; set; }
    }

    public enum ServerCategory { Balanced, Fleeter, Miner, Graveyard };

    public enum ServerLabel { Empty, New, Graveyard };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ServerCategoryConverter.Singleton,
                ServerLabelConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ServerCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ServerCategory) || t == typeof(ServerCategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "balanced":
                    return ServerCategory.Balanced;
                case "fleeter":
                    return ServerCategory.Fleeter;
                case "miner":
                    return ServerCategory.Miner;
                case "graveyard":
                    return ServerCategory.Graveyard;
            }
            throw new Exception("Cannot unmarshal type ServerCategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ServerCategory)untypedValue;
            switch (value)
            {
                case ServerCategory.Balanced:
                    serializer.Serialize(writer, "balanced");
                    return;
                case ServerCategory.Fleeter:
                    serializer.Serialize(writer, "fleeter");
                    return;
                case ServerCategory.Miner:
                    serializer.Serialize(writer, "miner");
                    return;
                case ServerCategory.Graveyard:
                    serializer.Serialize(writer, "graveyard");
                    return;
            }
            throw new Exception("Cannot marshal type ServerCategory");
        }

        public static readonly ServerCategoryConverter Singleton = new ServerCategoryConverter();
    }

    internal class ServerLabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ServerLabel) || t == typeof(ServerLabel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "empty":
                    return ServerLabel.Empty;
                case "new":
                    return ServerLabel.New;
                case "graveyard":
                    return ServerLabel.Graveyard;
            }
            throw new Exception("Cannot unmarshal type ServerLabel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ServerLabel)untypedValue;
            switch (value)
            {
                case ServerLabel.Empty:
                    serializer.Serialize(writer, "empty");
                    return;
                case ServerLabel.New:
                    serializer.Serialize(writer, "new");
                    return;
                case ServerLabel.Graveyard:
                    serializer.Serialize(writer, "graveyard");
                    return;
            }
            throw new Exception("Cannot marshal type ServerLabel");
        }

        public static readonly ServerLabelConverter Singleton = new ServerLabelConverter();
    }
}
