using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ParserExcel;
using FrameworkTestJournals.DataProviders;
using ParserExcel.Search;

namespace FrameworkTestJournals.Tests
{
    [TestFixture]
   // [Parallelizable(ParallelScope.Fixtures)]
    class SearchTests
    {

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchWordTest(Journal currentJournal)
        {
            JournalPage journalPage = new JournalPage("chrome");
            journalPage.NavigateHere(currentJournal.JournalName);
            journalPage.CleanSearchBox();
            journalPage.EnterSearchQuery("Journal");

            Assert.True(journalPage.SearchResult.Displayed, $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void NegativeSearchWordTest(Journal currentJournal)
        {
            JournalPage journalPage = new JournalPage("chrome");
            journalPage.NavigateHere(currentJournal.JournalName);
            journalPage.CleanSearchBox();
            journalPage.EnterSearchQuery("fjng67%&");

            Assert.True(journalPage.ErrorWindow.Enabled, $"Problem in journal {currentJournal.JournalName}");
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchArticleTest(Journal currentJournal)
        {
            JournalPage journalPage = new JournalPage("chrome");
            journalPage.NavigateHere(currentJournal.JournalName);
            journalPage.CleanSearchBox();
            journalPage.EnterSearchQuery(journalPage.ArticleName.Text);

            Assert.True(journalPage.SearchResult.Displayed, $"Problem in journal {currentJournal.JournalName}");
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
