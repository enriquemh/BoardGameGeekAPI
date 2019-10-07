using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "ratings")]
    public class Ratings
    {
        [XmlElement(ElementName = "average")]
        public Average Average { get; set; }
        [XmlElement(ElementName = "averageweight")]
        public Averageweight Averageweight { get; set; }
        [XmlElement(ElementName = "bayesaverage")]
        public Bayesaverage Bayesaverage { get; set; }
        [XmlElement(ElementName = "median")]
        public Median Median { get; set; }
        [XmlElement(ElementName = "numcomments")]
        public Numcomments Numcomments { get; set; }
        [XmlElement(ElementName = "numweights")]
        public Numweights Numweights { get; set; }
        [XmlElement(ElementName = "owned")]
        public Owned Owned { get; set; }
        [XmlElement(ElementName = "ranks")]
        public Ranks Ranks { get; set; }
        [XmlElement(ElementName = "stddev")]
        public Stddev Stddev { get; set; }
        [XmlElement(ElementName = "trading")]
        public Trading Trading { get; set; }
        [XmlElement(ElementName = "usersrated")]
        public Usersrated Usersrated { get; set; }
        [XmlElement(ElementName = "wanting")]
        public Wanting Wanting { get; set; }
        [XmlElement(ElementName = "wishing")]
        public Wishing Wishing { get; set; }
    }
}