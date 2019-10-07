using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "minplayers")]
    public class Minplayers
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}