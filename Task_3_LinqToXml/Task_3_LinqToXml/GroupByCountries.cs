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
    class GroupByCountries
    {
        [Test]
        public void GroupByCountriesTest()
        {
            XDocument xDoc = XDocument.Load(Settings1.Default.Path);
            IEnumerable<XElement> elements = xDoc.Element("customers").Elements("customer");

            var groups = from record in elements
                         group record by (string)record.Element("country") into g

                         select new
                         {
                             key = g.Key,
                             g
                         };
            using (StreamWriter sw = new StreamWriter(Settings1.Default.PathToWrite, false, System.Text.Encoding.Default))
            {
                foreach (var group in groups)
                {
                    sw.WriteLine($"Country: {group.key}");
                    sw.WriteLine("Customers: ");
                    foreach (var p in group.g)
                    {
                        sw.WriteLine(p.Element("name").Value);
                    }
                   sw.WriteLine("");
                }
            }

        }
    }    
}
