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
        public Navigation()
        {

        }

        public void NavigateHere(String url)
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
        }

        public bool FindElement(string elementName)
        {
            return Element.getElement(elementName);
        }
    }
}
