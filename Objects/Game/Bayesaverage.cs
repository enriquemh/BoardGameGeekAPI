using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "bayesaverage")]
    public class Bayesaverage
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}