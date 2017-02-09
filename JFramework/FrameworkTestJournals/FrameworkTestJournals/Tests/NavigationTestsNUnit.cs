using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ParserExcel;
using System.Collections;
using FrameworkTestJournals.DataProviders;
using FrameworkTestJournals.Steps;

namespace FrameworkTestJournals
{
    [TestFixture]
    class NavigationTestsNUnit
    {
        StepJournalPage stepJP = new StepJournalPage();

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeadersTest(Journal currentJournal)
        {
            stepJP

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                Assert.True(journalPage.FindNavigationElement(currentHeader.HeaderName), $"Problem in journal {currentJournal.JournalName}");
            }
        }

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeaderItemsTest(Journal currentJournal)
        {
            JournalPage journalPage = new JournalPage("chrome");
            journalPage.NavigateHere(currentJournal.JournalName);

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                foreach (HeaderItem currentItem in currentHeader.Items)
                {
                    Assert.True(journalPage.FindNavigationElement(currentItem.ItemName), $"Problem in journal {currentJournal.JournalName}");
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

