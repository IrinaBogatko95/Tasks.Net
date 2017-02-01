using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    public class Header
    {
        private string headerName;
        private List<HeaderItem> items = new List<HeaderItem>();

        public string HeaderName { get { return headerName; } set { headerName = value; } }
        public List<HeaderItem> Items { get { return items; } set { items = value; } }


        public void AddItem(HeaderItem item)
        {
           items.Add(item);
        }

    }
}
