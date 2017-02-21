
namespace FrameworkTestJournals.Steps
{
   public  static class StepOpen
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
