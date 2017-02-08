using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrameworkTestJournals
{
    //Element in navigation menu of journal
    class ElementNavigation
    {
        public static bool GetNavigationElement(string textInElement)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//div[@id='zz1_TopNavigationMenu']//*[text()=\"{textInElement}\"]")).Enabled;
        }  
    }
}
