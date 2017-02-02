using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    public class Journal
    {

        private string journalName;
        private List<Header> allHeaders;

        public List<Header> AllHeaders { get { return allHeaders; } set { allHeaders = value; } }
        public string JournalName { get { return journalName; } set { journalName = value; } }

        public Journal(string journalName)
        {
            this.journalName = journalName;
            allHeaders = new List<Header>();
        }

        public void AddHeaderToList(Header header)
        {
            allHeaders.Add(header);
        }
    }
}
