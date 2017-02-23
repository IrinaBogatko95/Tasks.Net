using FrameworkTestJournals.PageObject;

namespace FrameworkTestJournals.Steps
{
    public class _FindStep
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
