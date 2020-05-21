using System.Collections.Generic;
using System.Xml.Serialization;

namespace OGameStatsRetriever.Models
{
    [XmlRoot(ElementName = "position")]
    public class Position
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "score")]
        public string Score { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "ships")]
        public string Ships { get; set; }
    }

    [XmlRoot(ElementName = "positions")]
    public class Positions
    {
        [XmlElement(ElementName = "position")]
        public List<Position> Position { get; set; }
    }

    [XmlRoot(ElementName = "planets")]
    public class Planets
    {
        [XmlElement(ElementName = "planet")]
        public List<Planet> Planet { get; set; }
    }

    [XmlRoot(ElementName = "playerData")]
    public class PlayerData
    {
        [XmlElement(ElementName = "positions")]
        public Positions Positions { get; set; }

        [XmlElement(ElementName = "planets")]
        public Planets Planets { get; set; }

        [XmlElement(ElementName = "alliance")]
        public Alliance Alliance { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string NoNamespaceSchemaLocation { get; set; }

        [XmlAttribute(AttributeName = "timestamp")]
        public string Timestamp { get; set; }

        [XmlAttribute(AttributeName = "serverId")]
        public string ServerId { get; set; }
    }
}
