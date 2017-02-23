using ParserExcel;
using NUnit.Framework;
using FrameworkTestJournals.DataFromXML;
using FrameworkTestJournals.DataProviders;
using FrameworkTestJournals.Steps;
using UnitTestProject1.Settings;

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
            data = _SerializationStep.GetAdvansedSearchData();
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchTitleTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);      
            _SearchStep.AdvansedSearchQuery(data.Title, 2);

            Assert.True(_FindStep.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchAuthorTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            _SearchStep.AdvansedSearchQuery(data.Author, 3);

            Assert.True(_FindStep.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchAbstractTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            _SearchStep.AdvansedSearchQuery(data.Abstract, 4);

            Assert.True(_FindStep.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchFullTextTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            _SearchStep.AdvansedSearchQuery(data.FullText, 5);

            Assert.True(_FindStep.SearchResultIsDisplayed());
        }

        //[Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchVolumeTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            //StepSearch.AdvansedSearchQuery(StepSerialization.GetAdvansedSearchData(), 5);

            Assert.True(_FindStep.SearchResultIsDisplayed());
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchIssueTest(Journal currentJournal, string journalName)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            _OpenStep.OpenPageWithJournal(journalName);
            _SearchStep.AdvansedSearchQuery(data.Issue, 7);

            Assert.True(_FindStep.SearchResultIsDisplayed());
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
