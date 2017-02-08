using NUnit.Framework;
using ParserExcel;
using ParserExcel.LogIn;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.DataProviders
{
    //Provides user with username and password
    class UserProviders
    {
        public static IEnumerable PositiveTestCaseWithUsers()
        {
            List<LogInUser> allUsers = ParseExcel.ParserForLogIn(SettingsPath.Default.UsersPositive);
            foreach (LogInUser currentUser in allUsers)
            {
                yield return new TestCaseData(currentUser);
            }
        }

        public static IEnumerable NegativeTestCaseWithUsers()
        {
            List<LogInUser> allUsers = ParseExcel.ParserForLogIn(SettingsPath.Default.UsersNegative);
            foreach (LogInUser currentUser in allUsers)
            {
                yield return new TestCaseData(currentUser);
            }
        }
    }
}
