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

        public List<Header> Allheaders { get { return allHeaders; } set { allHeaders = value; } }

        public string NameJournal { get { return nameJournal; } set { nameJournal = value; } }

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

        public int CountNames(List<Header> headers)
        {
            int i = 0;
            foreach(Header res in headers)
            {
                if (res.HeaderName != null)
                {
                    i++;
                }     
            }
            return i;
        }
    }
}
