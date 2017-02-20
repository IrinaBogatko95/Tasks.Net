using NUnit.Framework;
using FrameworkTestJournals.Steps;
using ParserExcel.LogIn;
using FrameworkTestJournals.Tests;
using FrameworkTestJournals.Settings;
using FrameworkTestJournals.DataProviders;
using FrameworkTestJournals.DataFromXML;

namespace FrameworkTestJournals
{
    [TestFixture]
    public class LogInTests : BaseTest
    {
        StepLogIn stepLogIn = new StepLogIn();

        [Test, TestCaseSource(typeof(UserProviders), "PositiveTestCaseWithUsers")]
        public void PositiveLogInTest(string username, string password)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenHomePage();
            stepLogIn.LogInUser(username, password);

            Assert.IsTrue(stepLogIn.LogOutButtonIsEnabled());
        }

        [Test, TestCaseSource(typeof(UserProviders), "NegativeTestCaseWithUsers")]
        public void NegativeLogInTest(string username, string password)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenHomePage();
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
