using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParseXml
{
    class Header
    {
        private List<HeaderItem> allHeaders;
        private string nameJournal;

        public Header(List<HeaderItem> allHeaders)
        {
           
            this.allHeaders = allHeaders;       
        }

        public List<HeaderItem> getAllHeaders()
        {
            return allHeaders;
        }

        public string getNameJournal()
        {
            return nameJournal;
        }
    }
}
