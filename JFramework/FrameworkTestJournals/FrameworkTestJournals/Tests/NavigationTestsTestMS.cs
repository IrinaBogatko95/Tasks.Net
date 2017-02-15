using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserExcel;
using System.Collections;
using FrameworkTestJournals.DataProviders;

namespace FrameworkTestJournals
{
    [TestClass]
    class NavigationTestsTestMS
    {
        //[TestMethod, DataSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeadersTest(Journal currentJournal)
        {
            JournalPage navigation = new JournalPage();
            navigation.NavigateHere($"http://journals.lww.com/" + currentJournal.JournalName);

        }

        //[Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public static void FindHeaderItemsTest(Journal currentJournal)
        {
            JournalPage navigation = new JournalPage();
            navigation.NavigateHere($"http://journals.lww.com/" + currentJournal.JournalName);


        }

        [ClassCleanup]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}

