using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "wishing")]
    public class Wishing
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}