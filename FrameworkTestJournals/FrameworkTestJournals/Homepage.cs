using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrameworkTestJournals
{
    class HomePage
    {
        public IWebElement LoginInput { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'txt_UserName')]")); } }
        public IWebElement PasswordInput { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'txt_Password')]")); } }
        public IWebElement LoginButton { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'LoginButton')]")); } }

        public IWebElement LogoutButton { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'Logout')]")); } }

        public IWebElement ErrorMessage { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'LoginSuccess')]")); } }


        public string HomePageUrl { get { return "http://journals.lww.com/pages/default.aspx"; } }

        //*[@id="ctl00_ctl45_g_e504d159_38de_4cbf_9f4d_b2c12b300979_ctl00_rfvUserName"]/div/p
        //*[@id="ctl00_ctl45_g_e504d159_38de_4cbf_9f4d_b2c12b300979_ctl00_rfvPassword"]/div/p

        public HomePage()
        {

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
