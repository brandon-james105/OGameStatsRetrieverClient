using System.Collections.Generic;
using System.Xml.Serialization;

namespace OGameStatsRetriever.Models
{
    [XmlRoot(ElementName = "player")]
    public class PlayerBrowseInfo
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }

        [XmlAttribute(AttributeName = "alliance")]
        public string Alliance { get; set; }
    }

    [XmlRoot(ElementName = "players")]
    public class Players
    {
        [XmlElement(ElementName = "player")]
        public List<PlayerBrowseInfo> Player { get; set; }

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
