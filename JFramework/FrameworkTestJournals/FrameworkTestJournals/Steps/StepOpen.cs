using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.Steps
{
    static class StepOpen
    {

        public static void OpenPageWithJournal(string journal)
        {
            var journalPage = new JournalPage();
            journalPage.NavigateHere(journal);
        }

        public static void OpenHomePage()
        {
            var homePage = new HomePage();
            homePage.NavigateHere();
        }
    }
}
