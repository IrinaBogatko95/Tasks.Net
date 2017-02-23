using NUnit.Framework;
using ParserExcel;
using FrameworkTestJournals.Steps;
using FrameworkTestJournals.DataProviders;
using UnitTestProject1.Settings;

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
            _OpenStep.OpenPageWithJournal(journalName);
            _SearchStep.SearchQuery("Journal");

            Assert.True(_FindStep.SearchResultIsDisplayed(), $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void NegativeSearchWordTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            _SearchStep.SearchQuery("fjng67%&");

            Assert.True(_FindStep.ErrorWindowIsEnabled(), $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchArticleTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            JournalPage journalPage = new JournalPage();
            _SearchStep.SearchQuery(journalPage.ArticleName.Text);

            Assert.True(_FindStep.SearchResultIsDisplayed(), $"Problem in journal {currentJournal.JournalName}");
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
