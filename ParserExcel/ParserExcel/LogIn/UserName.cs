using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel.LogIn
{
    public class UserName
    {
        private string currentUserName;      

        public string CurrentUserName { get { return currentUserName; } set { currentUserName = value; } }

        public UserName(string currentUserName)
        {
            this.currentUserName = currentUserName;
        }
    }
}
