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
        public string DeafaultUrl { get { return "http://journals.lww.com/"; } }

        public IWebElement ArticleName { get { return WebDriver.Driver.FindElement(By.XPath(".//article/div/div/header/h4/a")); } }      

        public JournalPage( ) { }


        public IWebElement GetNavigationElement(string textInElement)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//div[@id='zz1_TopNavigationMenu']//*[text()=\"{textInElement}\"]"));
        }

        public void NavigateHere(string journalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{DeafaultUrl}{journalName}");
        }


    }
}
