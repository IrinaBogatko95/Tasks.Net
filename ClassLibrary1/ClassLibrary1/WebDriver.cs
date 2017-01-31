﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;


namespace ClassLibrary1
{
    class WebDriver
    {
        private WebDriver() { }

        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                }

                return driver;
            }
        }

        public static void KillDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
