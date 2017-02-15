using FrameworkTestJournals.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.Steps
{
    class StepSearch
    {
        public static void SearchQuery(string query)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.CleanSearchBox();
            searchForm.EnterSearchQuery(query);
        }
    }
}
