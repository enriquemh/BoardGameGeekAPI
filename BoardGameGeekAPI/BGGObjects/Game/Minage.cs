using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "minage")]
    public class Minage
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}