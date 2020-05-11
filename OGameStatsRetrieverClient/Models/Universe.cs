using System.Collections.Generic;
using System.Xml.Serialization;

namespace OGameStatsRetrieverClient.Models
{
    [XmlRoot(ElementName = "moon")]
    public class Moon
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }
    }

    [XmlRoot(ElementName = "planet")]
    public class Planet
    {
        [XmlElement(ElementName = "moon")]
        public Moon Moon { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "player")]
        public string Player { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "coords")]
        public string Coords { get; set; }
    }

    [XmlRoot(ElementName = "universe")]
    public class Universe
    {
        [XmlElement(ElementName = "planet")]
        public List<Planet> Planet { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string NoNamespaceSchemaLocation { get; set; }

        [XmlAttribute(AttributeName = "timestamp")]
        public string Timestamp { get; set; }

        [XmlAttribute(AttributeName = "serverId")]
        public string ServerId { get; set; }

        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }
}
