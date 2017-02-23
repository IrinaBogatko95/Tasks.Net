using FrameworkTestJournals.DataFromXML;
using FrameworkTestJournals.Settings;

namespace FrameworkTestJournals.Steps
{
    public class _SerializationStep
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
