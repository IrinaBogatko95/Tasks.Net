using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    //Class contains header of journal an list of items of header
    public class Header
    {
        private string headerName;
        private List<HeaderItem> items;

        public string HeaderName { get { return headerName; } set { headerName = value; } }
        public List<HeaderItem> Items { get { return items; } set { items = value; } }

        public Header(string headerName)
        {
            this.headerName = headerName;
            items = new List<HeaderItem>();
        }

        public void AddItemToList(HeaderItem headerItem)
        {
            items.Add(headerItem);
        }
    }
}
