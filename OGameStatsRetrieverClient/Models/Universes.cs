using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Xml2CSharp
{
	[XmlRoot(ElementName = "universe")]
	public class UniversesListUniverse
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "href")]
		public string Href { get; set; }
	}

	[XmlRoot(ElementName = "universes")]
	public class Universes
	{
		[XmlElement(ElementName = "universe")]
		public List<UniversesListUniverse> Universe { get; set; }
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
