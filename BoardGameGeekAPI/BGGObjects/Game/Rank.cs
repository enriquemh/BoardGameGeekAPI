using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "rank")]
    public class Rank
    {
        [XmlAttribute(AttributeName = "bayesaverage")]
        public string Bayesaverage { get; set; }
        [XmlAttribute(AttributeName = "friendlyname")]
        public string Friendlyname { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}