using System.Collections.Generic;
using System.Xml.Serialization;

namespace OGameStatsRetrieverClient.Models
{
    [XmlRoot(ElementName = "player")]
    public class PlayerScore
    {
        [XmlAttribute(AttributeName = "position")]
        public string Position { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "score")]
        public string Score { get; set; }
    }

    [XmlRoot(ElementName = "alliance")]
    public class AllianceScore
    {
        [XmlAttribute(AttributeName = "position")]
        public string Position { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "score")]
        public string Score { get; set; }
    }


    [XmlRoot(ElementName = "highscore")]
    public class PlayerHighscore
    {
        [XmlElement(ElementName = "player")]
        public List<PlayerScore> Player { get; set; }

        [XmlAttribute(AttributeName = "category")]
        public string Category { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string NoNamespaceSchemaLocation { get; set; }

        [XmlAttribute(AttributeName = "timestamp")]
        public string Timestamp { get; set; }

        [XmlAttribute(AttributeName = "serverId")]
        public string ServerId { get; set; }
    }

    [XmlRoot(ElementName = "highscore")]
    public class AllianceHighscore
    {
        [XmlElement(ElementName = "alliance")]
        public List<AllianceScore> Alliance { get; set; }

        [XmlAttribute(AttributeName = "category")]
        public string Category { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string NoNamespaceSchemaLocation { get; set; }

        [XmlAttribute(AttributeName = "timestamp")]
        public string Timestamp { get; set; }

        [XmlAttribute(AttributeName = "serverId")]
        public string ServerId { get; set; }
    }

    public enum HighScoreCategory
    {
        Player = 1,
        Alliance = 2
    }

    public enum HighScoreType
    {
        Total = 0,
        Economy = 1,
        Research = 2,
        Military = 3,
        MilitaryLost = 4,
        MilitaryBuilt = 5,
        MilitaryDestroyed = 6,
        Honor = 7
    }
}
