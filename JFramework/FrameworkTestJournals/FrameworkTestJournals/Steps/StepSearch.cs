using FrameworkTestJournals.PageObject;
using OpenQA.Selenium;
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

        public static void AdvansedSearchQuery(string query, int numberTextBox)
        {
            SearchForm searchForm = new SearchForm();
            JournalPage journalPage = new JournalPage();
            journalPage.ClickAdvansedSearchButton();
            IWebElement textBox =  searchForm.GetAdvansedSearchTextbox(numberTextBox);
            searchForm.EnterAdvansedSearchQuery(query, textBox);
        }
    }
}
