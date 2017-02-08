using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrameworkTestJournals
{
    //Main page of journal
    class JournalPage
    {
        public string nameBrowser;

        public string DeafaultUrl { get { return "http://journals.lww.com/"; } }

        public IWebElement SearchTextBox { get { return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"ctl00_SearchBox_txtKeywords\"]")); } }
        public IWebElement SearchButton { get { return WebDriver.Driver.FindElement(By.XPath(" //*[@id=\"btnGlobalSearchMagnifier\"]")); } }
        public IWebElement SearchResult { get { return WebDriver.Driver.FindElement(By.XPath($"//*[contains(@id, 'searchResultsSpan')]")); } }

        public IWebElement ArticleName { get { return WebDriver.Driver.FindElement(By.XPath(".//article/div/div/header/h4/a")); } }
        public IWebElement ErrorWindow { get { return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"searchResultsSpan\"]/div/div[2]/span[1]/p[1]")); } }

        public JournalPage(string nameBrowser)
        {
            this.nameBrowser = nameBrowser;
            WebDriver.SetDriver(nameBrowser);
        }

        public void NavigateHere(string journalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{DeafaultUrl}{journalName}");
        }

        public bool FindNavigationElement(string elementName)
        {
            return ElementNavigation.GetNavigationElement(elementName);
        }

        public void EnterSearchQuery(string searchQuery)
        {
            SearchTextBox.SendKeys(searchQuery);
            SearchButton.Click();
        }

        public void CleanSearchBox()
        {
            SearchTextBox.Clear();
        }
    }
}
