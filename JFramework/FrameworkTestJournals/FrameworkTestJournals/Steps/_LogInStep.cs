using FrameworkTestJournals.PageObject;

namespace FrameworkTestJournals.Steps
{
    public class _LogInStep 
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
