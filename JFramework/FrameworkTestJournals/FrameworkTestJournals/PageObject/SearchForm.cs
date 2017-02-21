using OpenQA.Selenium;

namespace FrameworkTestJournals.PageObject
{
    class SearchForm
    {
        public IWebElement SearchTextBox { get { return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"ctl00_SearchBox_txtKeywords\"]")); } }
        public IWebElement SearchButton { get { return WebDriver.Driver.FindElement(By.XPath(" //*[@id=\"btnGlobalSearchMagnifier\"]")); } }
        public IWebElement AdvansedSearchButton { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'searchAgain')]")); } }
        public IWebElement SearchResult { get { return WebDriver.Driver.FindElement(By.XPath($"//*[contains(@id, 'searchResultsSpan')]")); } }

        public IWebElement ErrorWindow { get { return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"wpSearchResults\"]/div/div[2]/span[1]/p[1]/b")); } }

        public void EnterSearchQuery(string searchQuery)
        {
            SearchTextBox.SendKeys(searchQuery);
            SearchButton.Click();
        }

        public void EnterAdvansedSearchQuery(string searchQuery, IWebElement searchTextBox)
        {
            searchTextBox.SendKeys(searchQuery);
            AdvansedSearchButton.Click();
        }

        public IWebElement GetAdvansedSearchTextbox(int numberOfTextBox)
        {
            return WebDriver.Driver.FindElement(By.XPath($".//*[@id='keywords_input_{numberOfTextBox}']"));
        }

        public void CleanSearchBox()
        {
            SearchTextBox.Clear();
        }
    }
}
