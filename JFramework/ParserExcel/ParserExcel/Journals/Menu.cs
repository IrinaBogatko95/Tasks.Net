using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    //Class contains menu of journal
    public class Menu
    {
        private string menuName;

        public string MenuName { get { return menuName; } set { menuName = value; } }

        public Menu(string headerName)
        {
            this.menuName = headerName;

        }
    }
}
