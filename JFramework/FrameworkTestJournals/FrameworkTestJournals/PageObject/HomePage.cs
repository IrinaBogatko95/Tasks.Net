

namespace FrameworkTestJournals
{
    //Main page of journals.lww.com
    class HomePage 
    {
        public string HomePageUrl { get { return "http://journals.lww.com/pages/default.aspx"; } }


        public void NavigateHere()
        {
            WebDriver.Driver.Navigate().GoToUrl(HomePageUrl);
        }

        public string CurrentURL()
        {
            return WebDriver.Driver.Url;
        }
    }
}
