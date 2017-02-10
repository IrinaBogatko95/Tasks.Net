using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    //Journal contains name of journal and list with menu in navigation
    public class Journal
    {

        private string journalName;
        private List<Menu> allMenu;

        public List<Menu> AllMenu { get { return allMenu; } set { allMenu = value; } }
        public string JournalName { get { return journalName; } set { journalName = value; } }

        public Journal(string journalName)
        {
            this.journalName = journalName;
            allMenu = new List<Menu>();
        }

        public void AddMenuToList(Menu header)
        {
            allMenu.Add(header);
        }
    }
}
