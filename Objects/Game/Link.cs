using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "link")]
    public class Link
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}