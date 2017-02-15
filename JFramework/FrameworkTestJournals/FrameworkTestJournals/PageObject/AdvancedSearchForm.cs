using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
