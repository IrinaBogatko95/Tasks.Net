using System.IO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Text;
using System.Threading.Tasks;
using FrameworkTestJournals.DataProviders;
using ParserExcel.LogIn;

namespace FrameworkTestJournals
{
    [TestFixture]
    public class LogInTests
    {
        //[Test]
        public void PositiveLogInTest()
        {
            var homePage = new HomePage("chrome");
            homePage.NavigateHere();
            homePage.Login("irynabahatka1", "12345678");
            Assert.True(homePage.LogoutButton.Enabled);
        }

       // [Test, TestCaseSource(typeof(UserProviders), "NegativeTestCaseWithUsers")]
        public void NegativeLogInTest(LogInUser currenUser)
        {
            var homePage = new HomePage("chrome");
            homePage.NavigateHere();
            homePage.Login(currenUser.CurrentUserName, currenUser.CurrentPassword);
            Assert.True(homePage.LoginButton.Displayed);
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
