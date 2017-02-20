using NUnit.Framework;
using ParserExcel;
using FrameworkTestJournals.DataProviders;
using FrameworkTestJournals.Steps;
using FrameworkTestJournals.DataFromXML;
using FrameworkTestJournals.Settings;

namespace FrameworkTestJournals.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    class AdvancedSearchTests : BaseTest
    {
        public static AdvansedSearchData data;

        [OneTimeSetUp]
        public void GetData()
        {
            data = StepSerialization.GetAdvansedSearchData();
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchTitleTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);      
            StepSearch.AdvansedSearchQuery(data.Title, 2);

            Assert.True(StepFind.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchAuthorTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            StepSearch.AdvansedSearchQuery(data.Author, 3);

            Assert.True(StepFind.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchAbstractTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            StepSearch.AdvansedSearchQuery(data.Abstract, 4);

            Assert.True(StepFind.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchFullTextTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            StepSearch.AdvansedSearchQuery(data.FullText, 5);

            Assert.True(StepFind.SearchResultIsDisplayed());
        }

        //[Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchVolumeTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            //StepSearch.AdvansedSearchQuery(StepSerialization.GetAdvansedSearchData(), 5);

            Assert.True(StepFind.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchIssueTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(journalName);
            StepSearch.AdvansedSearchQuery(data.Issue, 6);

            Assert.True(StepFind.SearchResultIsDisplayed());
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
