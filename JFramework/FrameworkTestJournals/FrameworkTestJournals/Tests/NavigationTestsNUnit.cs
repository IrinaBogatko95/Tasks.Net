using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ParserExcel;
using System.Collections;
using FrameworkTestJournals.DataProviders;
using FrameworkTestJournals.Steps;
using FrameworkTestJournals.Tests;

namespace FrameworkTestJournals
{
    [TestFixture]
    class NavigationTestsNUnit : BaseTest
    {
       public StepFind stepFind = new StepFind();

        [Test, TestCaseSource(typeof(JournalsProvider), "TestCaseWithJournals")]
        public void FindMenuTest(Journal currentJournal)
        {
            ChooseBrowser(SettingsNameBrowser.Default.CHROME);
            StepOpen.OpenPageWithJournal(currentJournal.JournalName);
            
            foreach (Menu currentMenu in currentJournal.AllMenu)
            {
                Assert.True(stepFind.MenuNavigationIsEnabled(currentMenu.MenuName), $"Problem in journal {currentJournal.JournalName}");
            }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}

