using NUnit.Framework;
using ParserExcel;
using FrameworkTestJournals.Steps;
using FrameworkTestJournals.Tests;
using FrameworkTestJournals.DataProviders;
using UnitTestProject1.Settings;

namespace FrameworkTestJournals
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    class NavigationTestsNUnit : BaseTest
    {
       public _FindStep stepFind = new _FindStep();

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public void FindMenuTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            
            foreach (Menu currentMenu in currentJournal.AllMenu)
            {
                Assert.True(stepFind.MenuNavigationIsEnabled(currentMenu.MenuName), $"Problem in journal {currentJournal.JournalName}");
            }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}

