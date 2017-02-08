using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    //Class consists of item of header in journal
    public class HeaderItem
    {
        private string itemName;

        public string ItemName { get { return itemName; } set { itemName = value; } }

        public HeaderItem(string itemName)
        {
            this.itemName = itemName;
        }

    }
}
