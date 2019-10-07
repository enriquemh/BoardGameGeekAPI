using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "median")]
    public class Median
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}