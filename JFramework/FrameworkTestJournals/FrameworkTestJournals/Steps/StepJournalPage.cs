using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.Steps
{
    class StepJournalPage
    {

        public void OpenJournalPage(string journal)
        {
            var journalPage = new JournalPage("chrome");
            journalPage.NavigateHere(journal);
        }
    }
}
