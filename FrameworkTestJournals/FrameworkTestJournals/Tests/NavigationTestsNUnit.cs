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
    class NavigationTestsNUnit
    {
     // [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeadersTest(Journal currentJournal)
        {
            Navigation homepage = new Navigation();
            homepage.NavigateHere($"http://journals.lww.com/" + currentJournal.JournalName);

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                Assert.True(homepage.FindElement(currentHeader.HeaderName), $"Problem in journal {currentJournal.JournalName}");
            }

        }

       //[Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeaderItemsTest(Journal currentJournal)
        {
            Navigation homepage = new Navigation();
            homepage.NavigateHere($"http://journals.lww.com/" + currentJournal.JournalName);

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                foreach (HeaderItem currentItem in currentHeader.Items)
                {
                    Assert.True(homepage.FindElement(currentItem.ItemName), $"Problem in journal {currentJournal.JournalName}");
                }
            }
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}

