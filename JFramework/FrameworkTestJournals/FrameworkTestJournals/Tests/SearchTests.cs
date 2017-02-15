using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ParserExcel;
using FrameworkTestJournals.DataProviders;
using ParserExcel.Search;
using FrameworkTestJournals.Steps;

namespace FrameworkTestJournals.Tests
{
    [TestFixture]
   // [Parallelizable(ParallelScope.Fixtures)]
    class SearchTests : BaseTest
    {

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchWordTest(Journal currentJournal)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(currentJournal.JournalName);
            StepSearch.SearchQuery("Journal");

            Assert.True(StepFind.SearchResultIsDisplayed(), $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void NegativeSearchWordTest(Journal currentJournal)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(currentJournal.JournalName);
            StepSearch.SearchQuery("fjng67%&");

            Assert.True(StepFind.ErrorWindowIsEnabled(), $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchArticleTest(Journal currentJournal)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(currentJournal.JournalName);
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
