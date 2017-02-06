using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel.LogIn
{
    public class LogInUser
    {
        private string currentUserName;
        private string currentPassword;

        public string CurrentUserName { get { return currentUserName; } set { currentUserName = value; } }
        public string CurrentPassword { get { return currentPassword; } set { currentPassword = value; } }

        public LogInUser(string currentUserName, string currentPassword)
        {
            this.currentUserName = currentUserName;
            this.currentPassword = currentPassword;
        }

        //private List<UserName> allUserNames;
        //private List<Password> allPasswords;

        //public List<UserName> AllUserNames { get { return allUserNames; } set { allUserNames = value; } }
        //public List<Password> AllPasswords { get { return allPasswords; } set { allPasswords = value; } }

        //public LogInUser()
        //{
        //    allUserNames = new List<UserName>();
        //    allPasswords = new List<Password>();
        //}

        //public void AddUserNameToList(UserName userName)
        //{
        //    allUserNames.Add(userName);
        //}

        //public void AddPasswordToList(Password password)
        //{
        //    allPasswords.Add(password);
        //}
    }
}
