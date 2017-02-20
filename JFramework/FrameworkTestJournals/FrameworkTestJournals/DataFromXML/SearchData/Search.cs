using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
