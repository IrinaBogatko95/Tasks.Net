using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ClassLibrary1
{
    class IHeader
    {
        public static IWebElement Header;
        
        public static IWebElement getHeader(int i)
        {
           return Header = WebDriver.Driver.FindElement(By.XPath("//*[@id='zz2_RootAspMenu']/li[" + i + "]/a"));
        }
     
        
    }
}
