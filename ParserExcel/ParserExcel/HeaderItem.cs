using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    public class HeaderItem
    {
        private string itemOfHeader;
        public string ItemOfHeader { get { return itemOfHeader; } }

        public HeaderItem(string item)
        {
            this.itemOfHeader = item;
        }
    }
}
