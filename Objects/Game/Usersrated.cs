using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "usersrated")]
    public class Usersrated
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}