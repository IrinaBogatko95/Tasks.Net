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
        [Test, TestCaseSource(typeof(UserProviders), "PositiveTestCaseWithUsers")]
        public void PositiveLogInTest(LogInUser currenUser)
        {
            var homePage = new HomePage();
            homePage.NavigateHere();
            homePage.Login(currenUser.CurrentUserName, currenUser.CurrentPassword);
            Assert.True(homePage.LogoutButton.Displayed);
        }

        [Test, TestCaseSource(typeof(UserProviders), "NegativeTestCaseWithUsers")]
        public void NegativeLogInTest(LogInUser currenUser)
        {
            var homePage = new HomePage();
            homePage.NavigateHere();
            homePage.Login(currenUser.CurrentUserName, currenUser.CurrentPassword);
            Assert.True(homePage.ErrorMessage.Displayed);
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
