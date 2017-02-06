using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel.LogIn
{
    public class Password
    {
        private string currentPassword;

        public string CurrentPassword { get { return currentPassword; } set { currentPassword = value; } }

        public Password(string currentPassword)
        {
            this.currentPassword = currentPassword;
        }
    }
}
