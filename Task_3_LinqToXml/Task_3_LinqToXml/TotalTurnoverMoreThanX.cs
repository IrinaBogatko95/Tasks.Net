using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NUnit.Framework;

namespace Task_3_LinqToXml
{
    [TestFixture]
    public class TotalTurnoverMoreThanX
    {
        [Test]
        public static void TotalTurnoverMoreThanXTest()
        {
            XDocument xDoc = XDocument.Load(Settings1.Default.Path);
            IEnumerable<XElement> elements = xDoc.Element("customers").Elements("customer");

            int x = 30000;
            var customers = from customer in elements
                         where (customer.Element("orders").Elements("order").Sum(e1 => double.Parse(e1.Element("total").Value)) > x)
            select new
                         { 
                             name = customer.Element("name").Value                           
                         };

            using (StreamWriter sw = new StreamWriter(Settings1.Default.Task3, false, System.Text.Encoding.Default))
            {
                sw.WriteLine($"Customers, whose total turnover (sum of all orders) exceeds the value of {x}: ");
                sw.WriteLine("");

                foreach (var someCustomer in customers)
                {
                        sw.WriteLine(someCustomer.name);
                }
            }
        }
    }
}
