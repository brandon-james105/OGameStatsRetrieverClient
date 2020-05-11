using System.Collections.Generic;
using System.Xml.Serialization;

namespace OGameStatsRetrieverClient.Models
{
    [XmlRoot(ElementName = "player")]
    public class AlliancePlayer
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "alliance")]
    public class Alliance
    {
        [XmlElement(ElementName = "player")]
        public List<AlliancePlayer> Player { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "tag")]
        public string Tag { get; set; }

        [XmlAttribute(AttributeName = "founder")]
        public string Founder { get; set; }

        [XmlAttribute(AttributeName = "foundDate")]
        public string FoundDate { get; set; }

        [XmlAttribute(AttributeName = "open")]
        public string Open { get; set; }

        [XmlAttribute(AttributeName = "logo")]
        public string Logo { get; set; }

        [XmlAttribute(AttributeName = "homepage")]
        public string Homepage { get; set; }
    }

    [XmlRoot(ElementName = "alliances")]
    public class Alliances
    {
        [XmlElement(ElementName = "alliance")]
        public List<Alliance> Alliance { get; set; }

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
