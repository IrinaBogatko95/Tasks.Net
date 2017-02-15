using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NUnit.Framework;

namespace Task_3_LinqToXml
{
   // [TestFixture]
    class MonthAndYearFirstOrder
    {
        //[Test]
        public static void Main() //TotalTurnoverMoreThanXTest()
        {
            XDocument xDoc = XDocument.Load(Settings1.Default.Path);
            IEnumerable<XElement> elements = xDoc.Element("customers").Elements("customer");

            var customers = from customer in elements
                            from customer.Element("orders").Elements("order")

                            select new
                            {
                                orderdate = customer.Element("orders").Elements("order")
                                 name = customer.Element("name").Value
                            };

            using (StreamWriter sw = new StreamWriter(Settings1.Default.Task4, false, System.Text.Encoding.Default))
            {
                foreach (var someCustomer in customers)
                {
                    sw.WriteLine($"Customer : {someCustomer.name} from {someCustomer.orderdate}");
                }
            }
        }
    }
}
