using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParseXml
{
    class HeaderItem
    {

        private string itemOfHeader;

        public HeaderItem(string item)
        {
            this.itemOfHeader = item;        
        }

        public string getItem()
        {
            return itemOfHeader;
        }
    }
}
