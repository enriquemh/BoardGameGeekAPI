using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "maxplayers")]
    public class Maxplayers
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}