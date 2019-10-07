using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "yearpublished")]
    public class Yearpublished
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}