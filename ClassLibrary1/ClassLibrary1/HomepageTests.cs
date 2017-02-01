using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using ParserExcel;
using System.Collections;

namespace ClassLibrary1
{

    [TestFixture]
    class HomepageTests
    {

        //[Test, TestCaseSource(typeof(TestCasesProvider), "TestCases")]
        public static void FindHeadersTest(Journal currentJournal, List<Header> allHeaders)
        {
            Homepage homepage = new Homepage();
            homepage.NavigateHere($"http://journals.lww.com/" + currentJournal.NameJournal);

            int nameQuantity = currentJournal.CountNames(allHeaders);

            for (int i = 0; i < nameQuantity; i++)
            {
                Assert.AreEqual(allHeaders.ElementAt(i).HeaderName, homepage.FindHeader(i + 1));
            }
            
        }

        [Test]
        public static void Test()
        {
            Homepage homepage = new Homepage();
            homepage.NavigateHere($"http://journals.lww.com/ccnq");
            List<Journal> allJournals = ParseExcel.Parser("D:\\Framework\\Styling\\Responsive-Batch-3.xlsx");
            Journal journal = allJournals.ElementAt(0);
            List<Header> allHeaders = journal.Allheaders;
            int nameQuantity = journal.CountNames(allHeaders);
            /* int i = 1;      
               homepage.Click(i);
               int j = 1;
               foreach (HeaderItem head in hed.Items)
               {
                   Assert.AreEqual(head.NameItemHeader, homepage.FindHeaderItem(i, j));
                   j++;
               }
               i++;
           }
           */
            foreach (Header hed in allHeaders)
            {
                List<HeaderItem> items = hed.Items;               
                    for (int i = 0; i < nameQuantity; i++)
                {
                    if (items.Count() == 0) { }
                    else
                    {

                        homepage.Click(i + 1);

                        for (int j = 1; j < items.Count; j++)
                        {
                            Assert.AreEqual(items.ElementAt(i).NameItemHeader, homepage.FindHeaderItem(i + 1, j));
                        }
                    }
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
        public static IEnumerable TestCases()
        {
            List<Journal> allJournals = ParseExcel.Parser("D:\\Framework\\Styling\\Responsive-Batch-3.xlsx");
            foreach (Journal currentJournal in allJournals)
            {
                List<Header> allHeaders = currentJournal.Allheaders;
                yield return new TestCaseData(currentJournal, allHeaders);
            }
        }
    }
}


