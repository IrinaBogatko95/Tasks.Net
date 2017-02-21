using OpenQA.Selenium;

namespace FrameworkTestJournals.PageObject
{
    class AdvancedSearchForm
    {
        public IWebElement SearchTextBox { get { return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"ctl00_SearchBox_txtKeywords\"]")); } }
        public IWebElement SearchButton { get { return WebDriver.Driver.FindElement(By.XPath(" //*[@id=\"btnGlobalSearchMagnifier\"]")); } }
        public IWebElement SearchResult { get { return WebDriver.Driver.FindElement(By.XPath($"//*[contains(@id, 'searchResultsSpan')]")); } }

        public IWebElement ErrorWindow { get { return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"searchResultsSpan\"]/div/div[2]/span[1]/p[1]")); } }

    }
}
