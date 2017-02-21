using FrameworkTestJournals.DataFromXML;
using FrameworkTestJournals.Settings;
using FrameworkTestJournals.Steps;
using NUnit.Framework;
using System.Collections;

namespace FrameworkTestJournals.DataProviders
{
    //Provides user with username and password
    public class UserProviders
    {
        public static IEnumerable PositiveTestCaseWithUsers()
        {
            var data = StepSerialization.GetLogInData(SettingsPath.Default.PositiveDataLogIn);
            foreach (User currentUser in data.Users)
            {
                yield return new TestCaseData(currentUser.Username, currentUser.Password);
            }
        }

        public static IEnumerable NegativeTestCaseWithUsers()
        {
            var data = StepSerialization.GetLogInData(SettingsPath.Default.NegativeDataLogIn);
            foreach (User currentUser in data.Users)
            {
                yield return new TestCaseData(currentUser.Username, currentUser.Password);
            }
        }
    }
}
