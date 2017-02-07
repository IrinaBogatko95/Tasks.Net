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
    class SearchTests
    {

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void PositiveSearchTest(Journal currentJournal)
        {
            Navigation navigation = new Navigation("chrome");
            navigation.NavigateHere(currentJournal.JournalName);
            
            List<SimpleSearch> allSearches = ParseExcel.ParserForSimpleSearch(SettingsPath.Default.SearchPositive);

            foreach (SimpleSearch currentSearch in  allSearches)
            {
                navigation.CleanSearchBox();
                navigation.EnterSearchQuery(currentSearch.SearchQueryName);
                Assert.True(navigation.FindSearchElement(currentSearch.SearchQueryName), $"Problem in journal {currentJournal.JournalName}");
            }

        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void NegativeSearchTest(Journal currentJournal)
        {
            Navigation navigation = new Navigation("chrome");
            navigation.NavigateHere(currentJournal.JournalName);

            List<SimpleSearch> allSearches = ParseExcel.ParserForSimpleSearch(SettingsPath.Default.SearchNegative);

            foreach (SimpleSearch currentSearch in allSearches)
            {
                navigation.CleanSearchBox();
                navigation.EnterSearchQuery(currentSearch.SearchQueryName);
                Assert.True(navigation.FindFalseSearchElement(currentSearch.SearchQueryName), $"Problem in journal {currentJournal.JournalName}");
            }

        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
