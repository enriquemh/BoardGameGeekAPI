using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "stddev")]
    public class Stddev
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}