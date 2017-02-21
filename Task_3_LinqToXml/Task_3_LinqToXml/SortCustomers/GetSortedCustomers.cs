﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Task_3_LinqToXml.Settings;

namespace Task_3_LinqToXml
{
    public class GetSortedCustomers
    {
        public XDocument xDoc = XDocument.Load(PathForFiles.Default.Path);
        public IEnumerable<XElement> allCustomers;

        public IEnumerable GetCustomersWithOrderMoreX(int x)
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
                                    let month = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month
                                    let year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                                    select $"{customer.Element("name").Value}, first order - month {month}, year {year}";
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
                                         let month = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month
                                         orderby month
                                         let year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                                         orderby month
                                         select $"{customer.Element("name").Value}, first order - {month} , year {year}";

            return customersSortedByMonth;
        }

        public IEnumerable GetCustomersSortedByYear()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customersSortedByYear = from customer in allCustomers.Where(e => e.Descendants("order").Any())
                                        let year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                                        let month = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month
                                        orderby year
                                        select $"{customer.Element("name").Value}, first order - {month} , year {year}";
            return customersSortedByYear;
        }

        public IEnumerable GetCustomersSortedByTurnover()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customersSortedByTurnover = from customer in allCustomers.Where(e => e.Descendants("order").Any())
                                            let turnover = customer.Element("orders").Elements("order").Sum(e1 => double.Parse(e1.Element("total").Value))
                                            let year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                                            let month = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month
                                            orderby turnover descending
                                            select $"{customer.Element("name").Value}, turnover {turnover}, first order - {month} , year {year}";
            return customersSortedByTurnover;
        }

        public IEnumerable GetCustomersSortedByName()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customersSortedByName = from customer in allCustomers.Where(e => e.Descendants("order").Any())
                                        let name = customer.Element("name").Value
                                        let year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                                        let month = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month
                                        orderby name
                                        select $"{name}, first order - {month} , year {year}";
            return customersSortedByName;
        }

        public IEnumerable GetCustomersWithInvalidData()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var customersWithoutCode = from customer in allCustomers.Where(e => (!e.Elements("region").Any()) ||
                                       e.Elements("postalcode").Any() && !e.Element("postalcode").Value.All(ch => char.IsDigit(ch) || ch == '-') || 
                                       !e.Element("phone").Value.Contains("(") && !e.Element("phone").Value.Contains(")"))
                                       let name = customer.Element("name")?.Value
                                       let region = customer.Element("region")?.Value
                                       let postalcode = customer.Element("postalcode")?.Value
                                       let phone = customer.Element("phone")?.Value
                                       select $"{name} - region: {region}, postalcode: {postalcode}, phone: {phone} ";
            return customersWithoutCode;
        }
    }
}