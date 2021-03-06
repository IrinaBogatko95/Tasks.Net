﻿using OpenQA.Selenium;

namespace FrameworkTestJournals
{
    //Main page of journal
    public class JournalPage
    {
        public string DeafaultUrl { get { return "http://journals.lww.com/"; } }

        public IWebElement ArticleName { get { return WebDriver.Driver.FindElement(By.XPath(".//article/div/div/header/h4/a")); } }    
        public IWebElement AdvansedSearchButton { get { return WebDriver.Driver.FindElement(By.XPath(".//*[@id='ctl00_SearchBox_lnkAdvanceSearch']")); } }  

        public JournalPage( ) { }


        public IWebElement GetNavigationElement(string textInElement)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//div[@id='zz1_TopNavigationMenu']//*[text()=\"{textInElement}\"]"));
        }

        public void NavigateHere(string journalName)
        {
            WebDriver.Driver.Navigate().GoToUrl($"{DeafaultUrl}{journalName}");
        }

        public void ClickAdvansedSearchButton()
        {
            AdvansedSearchButton.Click();
        }


    }
}
