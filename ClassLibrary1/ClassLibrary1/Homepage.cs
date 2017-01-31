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
        public By ArticlesAndIssues { get { return By.XPath("//*[@id='zz2_RootAspMenu']/li[1]/a"); } }
        public By ForAuthors { get { return By.XPath("//*[@id='zz2_RootAspMenu']/li[2]/a"); } }
        public By JournalInfo { get { return By.XPath("//*[@id='zz2_RootAspMenu']/li[3]/a"); } }

        public Homepage()
        {

        }

        public void NavigateHere(String url)
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
        }

        public IWebElement findFirstElement()
        {
            return WebDriver.Driver.FindElement(ArticlesAndIssues);
        }

        public IWebElement findSecondElement()
        {
            return WebDriver.Driver.FindElement(ForAuthors);
        }

        public IWebElement findThirdElement()
        {
            return WebDriver.Driver.FindElement(JournalInfo);
        }


    }
}
