using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FrameworkTestJournals
{
    class Navigation
    {
        public IWebElement SearchTextBox { get { return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"ctl00_SearchBox_txtKeywords\"]")); } }
        public IWebElement SearchButton { get { return WebDriver.Driver.FindElement(By.XPath(" //*[@id=\"btnGlobalSearchMagnifier\"]")); } }
        //public IWebElement ErrorSearch { get { return WebDriver.Driver.FindElement(By.XPath(" //*[@id=\"btnGlobalSearchMagnifier\"]")); } }
        public string DeafaultUrl { get { return "http://journals.lww.com/"; } }

        public string nameBrowser;

        public Navigation(string nameBrowser)
        {
            this.nameBrowser = nameBrowser;
            WebDriver.SetDriver(nameBrowser);
        }

        public void NavigateHere(string journalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{DeafaultUrl}{journalName}");
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

        public bool FindNavigationElement(string elementName)
        {
            return Element.GetNavigationElement(elementName);
        }

        public bool FindSearchElement(string elementName)
        {
            return Element.GetSearchElement(elementName);
        }

        public bool FindFalseSearchElement(string elementName)
        {
            return Element.FalseSearchElement(elementName);
        }
    }
}
