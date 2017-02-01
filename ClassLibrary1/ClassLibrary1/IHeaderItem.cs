using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ClassLibrary1
{
    class IHeaderItem
    {
        public static IWebElement HeaderItem;

        public static IWebElement getHeaderItem(int i, int j)
        {
            return HeaderItem = WebDriver.Driver.FindElement(By.XPath("id('zz2_RootAspMenu')/li["+ i +"]/ul/li["+ j + "]/a/span/span"));
        }


    }
}
