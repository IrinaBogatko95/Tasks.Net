using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ClassLibrary1
{
    class Homepage
    {
        public Homepage()
        {

        }

        public void NavigateHere(String url)
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
        }

        public string FindHeader(int i)
        {
            return IHeader.getHeader(i).Text;
        }

        public string FindHeaderItem(int i, int j)
        {
            return IHeaderItem.getHeaderItem(i, j).Text;
        }

        public void Click(int i)
        {
            IHeader.getHeader(i).Click();
        }

    }
}
