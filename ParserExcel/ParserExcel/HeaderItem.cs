using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    public class HeaderItem
    {
        private string nameItemOfHeader;
        public string NameItemHeader { get { return nameItemOfHeader; } }

        public HeaderItem(string item)
        {
            this.nameItemOfHeader = item;
        }
    }
}
