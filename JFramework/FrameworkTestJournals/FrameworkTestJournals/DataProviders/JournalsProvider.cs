using NUnit.Framework;
using ParserExcel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.DataProviders
{
    //Provides journals one by one
    class JournalsProvider
    {
        public static IEnumerable TestCaseWithJournals()
        {
            List<Journal> allJournals = ParseExcel.ParserForJournal(SettingsPath.Default.Path_Batch3);
            foreach (Journal currentJournal in allJournals)
            {
                yield return new TestCaseData(currentJournal);
            }
        }
    }
}
