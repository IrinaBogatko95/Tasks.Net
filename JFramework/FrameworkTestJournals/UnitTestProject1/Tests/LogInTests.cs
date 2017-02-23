using NUnit.Framework;
using FrameworkTestJournals.Steps;
using ParserExcel.LogIn;
using FrameworkTestJournals.Tests;
using FrameworkTestJournals.DataProviders;
using FrameworkTestJournals.DataFromXML;
using UnitTestProject1.Settings;

namespace FrameworkTestJournals
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class LogInTests : BaseTest
    {
        _LogInStep stepLogIn = new _LogInStep();

        [Test, TestCaseSource(typeof(UserProviders), "PositiveTestCaseWithUsers")]
        public void PositiveLogInTest(string username, string password)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenHomePage();
            stepLogIn.LogInUser(username, password);

            Assert.IsTrue(stepLogIn.LogOutButtonIsEnabled());
        }

        [Test, TestCaseSource(typeof(UserProviders), "NegativeTestCaseWithUsers")]
        public void NegativeLogInTest(string username, string password)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenHomePage();
            stepLogIn.LogInUser(username, password);

            Assert.IsTrue(stepLogIn.LogInButtonIsEnabled());
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
