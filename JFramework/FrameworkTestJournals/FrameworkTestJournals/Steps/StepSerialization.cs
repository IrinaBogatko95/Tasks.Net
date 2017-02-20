using FrameworkTestJournals.DataFromXML;
using FrameworkTestJournals.Settings;

namespace FrameworkTestJournals.Steps
{
    class StepSerialization
    {
        public static AdvansedSearchData GetAdvansedSearchData()
        {
           return AdvansedSearchData.DeserialiseAdvansedSearchData(SettingsPath.Default.DataAdvansedSearch);
        }

        public static AllUsers GetLogInData(string path)
        {
            return AllUsers.DeserialiseLogInData(path);
        }
    }
}
