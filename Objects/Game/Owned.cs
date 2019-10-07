using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "owned")]
    public class Owned
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}