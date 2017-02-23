using FrameworkTestJournals.PageObject;
using OpenQA.Selenium;

namespace FrameworkTestJournals.Steps
{
   public class _SearchStep
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
