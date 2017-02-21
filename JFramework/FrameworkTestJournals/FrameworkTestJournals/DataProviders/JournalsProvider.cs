using FrameworkTestJournals.Settings;
using NUnit.Framework;
using ParserExcel;
using System.Collections;
using System.Collections.Generic;

namespace FrameworkTestJournals.DataProviders
{
    //Provides journals one by one
   public class JournalsProvider
    {
        public static IEnumerable TestCaseWithJournals()
        {
            List<Journal> allJournals = ParseExcel.ParserForJournal(SettingsPath.Default.Path_Batch3);
            foreach (Journal currentJournal in allJournals)
            {
                yield return new TestCaseData(currentJournal, currentJournal.JournalName);
            }
        }
    }
}
