using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "statistics")]
    public class Statistics
    {
        [XmlAttribute(AttributeName = "page")]
        public string Page { get; set; }
        [XmlElement(ElementName = "ratings")]
        public Ratings Ratings { get; set; }
    }
}