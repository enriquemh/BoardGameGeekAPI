using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "numcomments")]
    public class Numcomments
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}