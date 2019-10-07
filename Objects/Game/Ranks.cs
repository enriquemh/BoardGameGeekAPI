using System.Collections.Generic;
using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "ranks")]
    public class Ranks
    {
        [XmlElement(ElementName = "rank")]
        public List<Rank> Rank { get; set; }
    }
}