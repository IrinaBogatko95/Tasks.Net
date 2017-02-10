using FrameworkTestJournals.PageObject;
using ParserExcel.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace FrameworkTestJournals.Steps
{
     class StepLogIn 
    {
        public LogInForm logInForm = new LogInForm();

        public void LogInUser(string userName, string password)
        {    
            logInForm.Login(userName, password);
        }

        public bool LogInButtonIsEnabled()
        {
           return logInForm.LoginButton.Enabled;
        }

        public bool LogOutButtonIsEnabled()
        {
            return logInForm.LogoutButton.Enabled;
        }
    }
}
