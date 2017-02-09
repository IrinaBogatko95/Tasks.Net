using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FrameworkTestJournals.PageObject;

namespace FrameworkTestJournals
{
    //Main page of journals.lww.com
    class HomePage 
    {
        public string nameBrowser;

        public string HomePageUrl { get { return "http://journals.lww.com/pages/default.aspx"; } }


        public HomePage(string nameBrowser)
        {
            this.nameBrowser = nameBrowser;
            WebDriver.SetDriver(nameBrowser);
        }

        public void NavigateHere()
        {
            WebDriver.Driver.Navigate().GoToUrl(HomePageUrl);
        }

        public string CurrentURL()
        {
            return WebDriver.Driver.Url;
        }
    }
}
