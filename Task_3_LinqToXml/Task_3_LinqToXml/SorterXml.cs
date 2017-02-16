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
   public class SorterXml
    {
        public XDocument xDoc = XDocument.Load(Settings1.Default.Path);
        public IEnumerable<XElement> allCustomers;

        public void OrderMoreThanX(int x)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customers = from customer in allCustomers
                                where customer.Element("orders").Elements("order").Any(e1 => double.Parse(e1.Element("total").Value) > x)
                            select new
                            {
                                name = customer.Element("name").Value
                            };

            using (StreamWriter sw = new StreamWriter(Settings1.Default.OrderMoreThanX, false, System.Text.Encoding.Default))
            {
                sw.WriteLine($"Customers, which have orders with sum more than {x}: ");

                foreach (var someCustomer in customers)
                {
                    sw.WriteLine(someCustomer.name);
                }
            }
        }

        public void TotalTurnoverMoreThanX(int x)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customers = from customer in allCustomers
                            where (customer.Element("orders").Elements("order").Sum(e1 => double.Parse(e1.Element("total").Value)) > x)
                            select new
                            {
                                name = customer.Element("name").Value
                            };

            using (StreamWriter sw = new StreamWriter(Settings1.Default.TotalTurnoverMoreThanX, false, System.Text.Encoding.Default))
            {
                sw.WriteLine($"Customers, whose total turnover (sum of all orders) exceeds the value of {x}: ");

                foreach (var someCustomer in customers)
                {
                    sw.WriteLine(someCustomer.name);
                }
            }
        }

        public void MonthAndYearFirstOrder()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");        
            var customersWithDate = from customer in allCustomers.Where(e => e.Descendants("order").Any())
                                    select new
                                    {
                                        name = customer.Element("name").Value,
                                        month = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month,
                                        year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                                    };

            using (StreamWriter sw = new StreamWriter(Settings1.Default.MonthAndYearFirstOrder, false, System.Text.Encoding.Default))
            {
                foreach (var someCustomer in customersWithDate)
                {
                    sw.WriteLine($"Customer: {someCustomer.name}  first order - month {someCustomer.month}, year {someCustomer.year} ");
                    sw.WriteLine("");
                }
            }
        }

        public void GroupByCountries()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var sortedCustomers = from record in allCustomers
                                  group record by (string)record.Element("country") into g

                                  select new
                                  {                                    
                                      key = g.Key,
                                      g
                                  };
            using (StreamWriter sw = new StreamWriter(Settings1.Default.SortByCountries, false, System.Text.Encoding.Default))
            {
                foreach (var sortedCustomer in sortedCustomers)
                {
                    sw.WriteLine($"Country: {sortedCustomer.key}");
                    sw.WriteLine("Customers: ");
                    foreach (var p in sortedCustomer.g)
                    {
                        sw.WriteLine(p.Element("name").Value);
                    }
                    sw.WriteLine("");
                }
            }
        }
    }
}
