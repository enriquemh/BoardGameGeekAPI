/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System.Xml.Serialization;

namespace BoardGameGeekAPI.BGGObjects.Game
{
    [XmlRoot(ElementName = "average")]
    public class Average
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
}
