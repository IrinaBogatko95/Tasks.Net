using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_LinqToXml
{
    class WriteResultsToFile
    {
        public static void WriteCustomerName(IEnumerable customers, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine($"Customers, which have orders with sum more than : ");

                foreach (var someCustomer in customers)
                {
                  //  sw.WriteLine(someCustomer.name);
                }
            }
        }

    }
}
