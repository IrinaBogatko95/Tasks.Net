using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3_LinqToXml
{
    public class GetSortedCustomers
    {
        public XDocument xDoc = XDocument.Load(Settings1.Default.Path);
        public IEnumerable<XElement> allCustomers;

        public IEnumerable  GetCustomersWithOrderMoreX(int x)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customers = from customer in allCustomers
                            where customer.Element("orders").Elements("order").Any(e1 => double.Parse(e1.Element("total").Value) > x)
                            select customer.Element("name").Value;
            return customers;
        }

        public IEnumerable GetCustomersWithTurnoverMoreX(int x)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customers = from customer in allCustomers
                            where (customer.Element("orders").Elements("order").Sum(e1 => double.Parse(e1.Element("total").Value)) > x)
                            select customer.Element("name").Value;
            return customers;
        }

        public IEnumerable GetCustomersWithDateFirstOrder()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customersWithDate = from customer in allCustomers.Where(e => e.Descendants("order").Any())
                                    select $"{customer.Element("name").Value}, first order - month {DateTime.Parse(customer.Descendants("orderdate").First().Value).Month}, year {DateTime.Parse(customer.Descendants("orderdate").First().Value).Year}";
            return customersWithDate;
        }

        public IEnumerable GetCustomersSortedByCountry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customers = from customer in allCustomers
                            let country = customer.Element("country").Value
                            orderby country
                            select $"{country} - {customer.Element("name").Value}";

            return customers;
        }

        public IEnumerable GetCustomersSortedByMonth()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customersSortedByMonth = from customer in allCustomers.Where(e => e.Descendants("order").Any())
                                    let month =DateTime.Parse(customer.Descendants("orderdate").First().Value).Month orderby month
                                    select $"{customer.Element("name").Value}, first order - {month} , year {DateTime.Parse(customer.Descendants("orderdate").First().Value).Year}";

            return customersSortedByMonth;
        }
    }
}
