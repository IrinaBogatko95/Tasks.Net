using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ParserExcel;
using System.Collections;
using FrameworkTestJournals.DataProviders;

namespace FrameworkTestJournals
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    class NavigationTestsNUnit
    {
        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeadersTest(Journal currentJournal)
        {
            JournalPage navigation = new JournalPage("chrome");
            navigation.NavigateHere(currentJournal.JournalName);

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                Assert.True(navigation.FindNavigationElement(currentHeader.HeaderName), $"Problem in journal {currentJournal.JournalName}");
            }
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeaderItemsTest(Journal currentJournal)
        {
            JournalPage navigation = new JournalPage("chrome");
            navigation.NavigateHere(currentJournal.JournalName);

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                foreach (HeaderItem currentItem in currentHeader.Items)
                {
                    Assert.True(navigation.FindNavigationElement(currentItem.ItemName), $"Problem in journal {currentJournal.JournalName}");
                }
            }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}

