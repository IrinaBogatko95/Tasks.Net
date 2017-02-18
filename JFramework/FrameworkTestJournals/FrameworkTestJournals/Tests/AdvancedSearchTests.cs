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
using FrameworkTestJournals.DataFromXML;

namespace FrameworkTestJournals.Tests
{
    [TestFixture]
    class AdvancedSearchTests : BaseTest
    {
        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void AdvansedSearchTitleTest(Journal currentJournal)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(currentJournal.JournalName);
            StepSearch.AdvansedSearchQuery(GetDataFromXML.getTitle(), 2);

            Assert.True(StepFind.SearchResultIsDisplayed(), $"Problem in journal {currentJournal.JournalName}");
        }
    }
}
