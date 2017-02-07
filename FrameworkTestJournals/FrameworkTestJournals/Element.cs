using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrameworkTestJournals
{
    class Element
    {
        public static bool GetNavigationElement(string textInElement)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//div[@id='zz1_TopNavigationMenu']//*[text()=\"{textInElement}\"]")).Enabled;
        }

        public static bool GetSearchElement(string textInElement)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//section[@id='wpSearchResults']//*[text()=\"{textInElement}\"]")).Enabled;
        }

        public static bool FalseSearchElement(string textInElement)
        {
            return WebDriver.Driver.FindElement(By.XPath("//*[@id=\"wpSearchResults\"]/div/div[2]/span[1]/p[1]")).Enabled;
        }

        
    }
}
