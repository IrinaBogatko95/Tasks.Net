using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;


namespace FrameworkTestJournals
{
    class WebDriver
    {
        private WebDriver() { }

        private static IWebDriver driver;

        public static IWebDriver Driver { get { return driver; } }

        public static void SetDriver(string nameDriver)
        {
            if (driver == null)
            {
                switch (nameDriver)
                {
                    case "chrome":
                        driver = new ChromeDriver();
                        driver.Manage().Window.Maximize();
                        break;

                    case "firefox":
                        driver = new FirefoxDriver();
                        driver.Manage().Window.Maximize();
                        break;

                    case "IE":
                        driver = new FirefoxDriver();
                        driver.Manage().Window.Maximize();
                        break;

                    default:
                        driver = new ChromeDriver();
                        driver.Manage().Window.Maximize();
                        break;
                }
            }
        }

        public static void KillDriver()
        {
            driver.Quit();
            driver = null;
        }

    }
}
