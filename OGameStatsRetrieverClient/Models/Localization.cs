using System.Collections.Generic;
using System.Xml.Serialization;

namespace OGameStatsRetrieverClient.Models
{
    [XmlRoot(ElementName = "name")]
    public class Descriptor
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "techs")]
    public class Techs
    {
        [XmlElement(ElementName = "name")]
        public List<Descriptor> Name { get; set; }
    }

    [XmlRoot(ElementName = "missions")]
    public class Missions
    {
        [XmlElement(ElementName = "name")]
        public List<Descriptor> Name { get; set; }
    }

    [XmlRoot(ElementName = "localization")]
    public class Localization
    {
        [XmlElement(ElementName = "techs")]
        public Techs Techs { get; set; }

        [XmlElement(ElementName = "missions")]
        public Missions Missions { get; set; }

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
