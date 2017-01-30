using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParseXml
{
    class Journal
    {
        private string nameJournal;
        private List<Header> allHeaders;

        public Journal(string nameJournal, List<Header> allHeaders)
        {
            this.nameJournal = nameJournal;
            this.allHeaders = allHeaders;            
        }

        public string getNameJournal()
        {
            return nameJournal;
        }

      
        public List<Header> getAllHeaders()
        {
            return allHeaders;
        }
    }
}
