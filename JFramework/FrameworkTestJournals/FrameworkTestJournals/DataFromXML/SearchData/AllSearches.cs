using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace FrameworkTestJournals.DataFromXML.SearchData
{
    [Serializable]
    public class AllSearches
    {
        [XmlElement("positiveSearches")]
        public List<Search> PositiveSearches { get; set; }

        [XmlElement("negativeSearches")]
        public List<Search> NegativeSearches { get; set; }

        public static AllUsers DeserialiseLogInData(string filePath)
        {
            var catalogSerialiser = new XmlSerializer(typeof(AllUsers));
            return (AllUsers)catalogSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}
