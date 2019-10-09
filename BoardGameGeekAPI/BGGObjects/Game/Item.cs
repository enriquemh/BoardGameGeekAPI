using System.Collections.Generic;
using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "image")]
        public string Image { get; set; }
        [XmlElement(ElementName = "link")]
        public List<Link> Link { get; set; }
        [XmlElement(ElementName = "maxplayers")]
        public Maxplayers Maxplayers { get; set; }
        [XmlElement(ElementName = "maxplaytime")]
        public Maxplaytime Maxplaytime { get; set; }
        [XmlElement(ElementName = "minage")]
        public Minage Minage { get; set; }
        [XmlElement(ElementName = "minplayers")]
        public Minplayers Minplayers { get; set; }
        [XmlElement(ElementName = "minplaytime")]
        public Minplaytime Minplaytime { get; set; }
        [XmlElement(ElementName = "name")]
        public List<Name> Name { get; set; }
        [XmlElement(ElementName = "playingtime")]
        public Playingtime Playingtime { get; set; }
        [XmlElement(ElementName = "poll")]
        public List<Poll> Poll { get; set; }
        [XmlElement(ElementName = "statistics")]
        public Statistics Statistics { get; set; }
        [XmlElement(ElementName = "thumbnail")]
        public string Thumbnail { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "yearpublished")]
        public Yearpublished Yearpublished { get; set; }
    }
}