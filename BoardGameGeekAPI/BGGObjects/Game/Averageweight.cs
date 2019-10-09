using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "averageweight")]
    public class Averageweight
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}