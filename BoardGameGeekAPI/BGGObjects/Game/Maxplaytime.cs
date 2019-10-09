using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "maxplaytime")]
    public class Maxplaytime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}