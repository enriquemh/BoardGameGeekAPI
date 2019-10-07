using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "trading")]
    public class Trading
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}