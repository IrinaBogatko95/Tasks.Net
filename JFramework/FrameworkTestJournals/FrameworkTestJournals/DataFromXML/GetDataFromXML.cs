using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrameworkTestJournals.DataFromXML
{
    class GetDataFromXML
    {
        public static XDocument xDoc = XDocument.Load("C:\\Users\\Iryna_Bahatka1\\Documents\\Tasks.Net\\JFramework\\FrameworkTestJournals\\FrameworkTestJournals\\DataAdvansedSearch.xml");

        public static string getTitle()
        {
            return xDoc.Element("journal").Element("title").Value;                
        }

        public static string getAuthor()
        {
            return xDoc.Element("journal").Element("author").Value;
        }

        public static string getAbstract()
        {
            return xDoc.Element("journal").Element("abstract").Value;
        }

        public static string getFullText()
        {
            return xDoc.Element("journal").Element("full_text").Value;
        }

        public static string getIssue()
        {
            return xDoc.Element("journal").Element("issue").Value;
        }
    }
}
