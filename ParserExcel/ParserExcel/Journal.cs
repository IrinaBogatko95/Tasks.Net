using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    public class Journal
    {
        private string nameJournal;
        private List<Header> allHeaders = new List<Header>();

        public Journal(string nameJournal)
        {
            this.nameJournal = nameJournal;
        }

        public void AddHeader(Header header)
        {
            allHeaders.Add(header);
        }

        public Header GetHeader(int i)
        {
            return allHeaders.ElementAt(i);
        }
    }
}
