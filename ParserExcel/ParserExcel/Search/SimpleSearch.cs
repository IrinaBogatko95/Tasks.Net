using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel.Search
{
    public class SimpleSearch
    {
        private string searchQueryName;

        public string SearchQueryName { get { return searchQueryName; } set { searchQueryName = value; } }

        public SimpleSearch(string searchQueryName)
        {
            this.searchQueryName = searchQueryName;
        }
    }
}
