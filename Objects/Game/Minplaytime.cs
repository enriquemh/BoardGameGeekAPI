using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "minplaytime")]
    public class Minplaytime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}