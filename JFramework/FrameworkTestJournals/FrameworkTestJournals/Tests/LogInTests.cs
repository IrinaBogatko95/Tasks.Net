using System.IO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkTestJournals.Steps;
using FrameworkTestJournals.DataProviders;
using ParserExcel.LogIn;

namespace FrameworkTestJournals
{
    [TestFixture]
    public class LogInTests
    {
        StepLogIn step = new StepLogIn();

        [Test, TestCaseSource(typeof(UserProviders), "PositiveTestCaseWithUsers")]
        public void PositiveLogInTest(LogInUser currenUser)
        {
            step.OpenPage();
            step.LogIn(currenUser.CurrentUserName, currenUser.CurrentPassword);
            Assert.IsTrue(step.LogOutButtonIsEnabled());
        }

        [Test, TestCaseSource(typeof(UserProviders), "NegativeTestCaseWithUsers")]
        public void NegativeLogInTest(LogInUser currenUser)
        {
            step.OpenPage();
            step.LogIn(currenUser.CurrentUserName, currenUser.CurrentPassword);
            Assert.IsTrue(step.LogInButtonIsEnabled());
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
