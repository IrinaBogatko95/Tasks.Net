using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrameworkTestJournals
{
    //Main page of journals.lww.com
    class HomePage
    {
        public string nameBrowser;

        public string HomePageUrl { get { return "http://journals.lww.com/pages/default.aspx"; } }

        public IWebElement LoginInput { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'txt_UserName')]")); } }
        public IWebElement PasswordInput { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'txt_Password')]")); } }

        public IWebElement LoginButton { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'LoginButton')]")); } }
        public IWebElement LogoutButton { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'Logout')]")); } }

        public HomePage(string nameBrowser)
        {
            this.nameBrowser = nameBrowser;
            WebDriver.SetDriver(nameBrowser);
        }

        public void Login(string user, string pasw)
        {
            LoginInput.SendKeys(user);
            PasswordInput.SendKeys(pasw);
            LoginButton.Click();
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
