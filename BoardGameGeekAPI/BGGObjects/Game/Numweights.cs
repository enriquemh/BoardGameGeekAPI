using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "numweights")]
    public class Numweights
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}