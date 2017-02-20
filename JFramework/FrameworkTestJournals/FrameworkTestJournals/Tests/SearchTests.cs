using NUnit.Framework;
using ParserExcel;
using FrameworkTestJournals.Steps;
using FrameworkTestJournals.Settings;
using FrameworkTestJournals.DataProviders;

namespace FrameworkTestJournals.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    class SearchTests : BaseTest
    {
        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchWordTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            StepSearch.SearchQuery("Journal");

            Assert.True(StepFind.SearchResultIsDisplayed(), $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void NegativeSearchWordTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            StepSearch.SearchQuery("fjng67%&");

            Assert.True(StepFind.ErrorWindowIsEnabled(), $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchArticleTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            JournalPage journalPage = new JournalPage();
            StepSearch.SearchQuery(journalPage.ArticleName.Text);

            Assert.True(StepFind.SearchResultIsDisplayed(), $"Problem in journal {currentJournal.JournalName}");
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
