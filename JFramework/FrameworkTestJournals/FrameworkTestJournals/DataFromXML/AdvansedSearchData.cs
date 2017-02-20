using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FrameworkTestJournals.DataFromXML
{
    [Serializable]
    public class AdvansedSearchData
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("abstract")]
        public string Abstract { get; set; }

        [XmlElement("fullText")]
        public string FullText { get; set; }

        [XmlElement("issue")]
        public string Issue { get; set; }

        public AdvansedSearchData()
        {

        }

        public AdvansedSearchData(string title, string author, string _abstract, string fullText, string issue)
        {
            this.Title = title;
            this.Author = author;
            this.Abstract = _abstract;
            this.FullText = fullText;
            this.Issue = issue;
        }


        public static AdvansedSearchData DeserialiseAdvansedSearchData(string filePath)
        {
            var catalogSerialiser = new XmlSerializer(typeof(AdvansedSearchData));
            return  (AdvansedSearchData)catalogSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}
