using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExcel
{
    class Pr
    {
        public static void Main()
        {
           
            List<Journal> allJournals = ParseExcel.Parser(Settings1.Default.Path);
            Journal journal = allJournals.ElementAt(0);
            List<Header> header = journal.Allheaders;

            foreach (Header res in header)
            {
                List<HeaderItem> items = res.Items;
                Console.WriteLine(res.HeaderName);
            }
        

            
            Console.ReadKey();
        }
    }
}
