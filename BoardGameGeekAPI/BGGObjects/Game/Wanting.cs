using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "wanting")]
    public class Wanting
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}