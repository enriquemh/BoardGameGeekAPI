using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "playingtime")]
    public class Playingtime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}