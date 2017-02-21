using System.Xml.Serialization;

namespace FrameworkTestJournals.DataFromXML.SearchData
{
    public class Search
    {
        [XmlElement("search")]
        public string SearchQuery { get; set; }

        public Search()
        {

        }

        public Search(string searchQuery)
        {
            this.SearchQuery = searchQuery;
        }

    }
}
