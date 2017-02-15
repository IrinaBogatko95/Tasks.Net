using FrameworkTestJournals.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.Steps
{
    class StepFind
    {

        public bool MenuNavigationIsEnabled(string elementName)
        {
            JournalPage journalPage = new JournalPage();
            return journalPage.GetNavigationElement(elementName).Enabled;
        }

        public static bool SearchResultIsDisplayed()
        {
            SearchForm searchForm = new SearchForm();
            return searchForm.SearchResult.Displayed; 
        }

        public static bool ErrorWindowIsEnabled()
        {
            SearchForm searchForm = new SearchForm();
            return searchForm.ErrorWindow.Enabled;
        }

    }
}
