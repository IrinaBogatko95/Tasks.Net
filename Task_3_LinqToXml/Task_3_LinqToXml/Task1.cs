using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NUnit.Framework;
using System.Globalization;

namespace Task_3_LinqToXml
{
    [TestFixture]
    class Task1
    {
        [Test]
        public static void TestTask1()
        {
            XDocument xDoc = XDocument.Load(Settings1.Default.Path);
            IEnumerable<XElement> elements = xDoc.Element("customers").Elements("customer");

            var customers = from customer in elements
                           // where (customer.Element("orders").Elements("order")(e1 => double.Parse(e1.Element("total").Value)) > x)
                            select new
                            {
                                name = customer.Element("name").Value
                            };

            using (StreamWriter sw = new StreamWriter(Settings1.Default.Task1, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Customers: ");

              //  foreach (var someCustomer in customers)
                {
                   // sw.WriteLine(someCustomer.name);

                    sw.WriteLine("");
                }
            }
        }
    }
}
