using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel.LogIn
{
    //Username and password for login
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
    }
}
