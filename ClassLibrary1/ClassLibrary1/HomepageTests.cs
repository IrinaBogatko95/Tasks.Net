using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace ClassLibrary1
{

    [TestFixture]
    class HomepageTests
    {

        [Test]
        public void FindElementsTest()
        {
            var homepage = new Homepage();
            homepage.NavigateHere("http://journals.lww.com/ccnq");
            IWebElement first = homepage.findFirstElement();
          
            Assert.IsTrue(WebDriver.Driver.PageSource.Contains("CE"));
            // Assert.AreEqual("Articles & issues", first.ToString());
        }
    }
}
