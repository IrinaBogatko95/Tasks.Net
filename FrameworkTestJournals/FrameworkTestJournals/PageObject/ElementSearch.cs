using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrameworkTestJournals.PageObject
{
    //Search text-box
    class ElementSearch
    {
        public static IWebElement GetSearchElement()
        {
            return WebDriver.Driver.FindElement(By.XPath($"//*[contains(@id, 'searchResultsSpan')]"));
        }
    }
}
