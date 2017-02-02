using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ParserExcel;
using System.Collections;

namespace FrameworkTestJournals
{
    [TestFixture]
    class HomepageTests
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCaseWithJournals")]
        public static void FindHeadersTest(Journal currentJournal)
        {
            Homepage homepage = new Homepage();
            homepage.NavigateHere($"http://journals.lww.com/" + currentJournal.JournalName);

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                Assert.True(homepage.FindElement(currentHeader.HeaderName), $"Problem in journal{currentJournal.JournalName}");
            }

        }

        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCaseWithJournals")]
        public static void FindHeaderItemsTest(Journal currentJournal)
        {
            Homepage homepage = new Homepage();
            homepage.NavigateHere($"http://journals.lww.com/" + currentJournal.JournalName);

            foreach (Header currentHeader in currentJournal.AllHeaders)
            {
                foreach (HeaderItem currentItem in currentHeader.Items)
                {
                    Assert.True(homepage.FindElement(currentItem.ItemName), $"Problem in journal{currentJournal.JournalName}");
                }
            }
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }

    public class TestCasesProvider
    {
        public static IEnumerable TestCaseWithJournals()
        {
            List<Journal> allJournals = ParseExcel.Parser();
            foreach (Journal currentJournal in allJournals)
            {
                yield return new TestCaseData(currentJournal);
            }
        }
    }
}

