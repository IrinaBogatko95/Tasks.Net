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
   public class SorterXml
    {
        public GetSortedCustomers getCustomers;

        public void OrderMoreThanX(int x)
        {
            getCustomers = new GetSortedCustomers();
            var customers = getCustomers.GetCustomersWithOrderMoreX(x);                         

            using (StreamWriter sw = new StreamWriter(Settings1.Default.OrderMoreThanX, false, System.Text.Encoding.Default))
            {                
                sw.WriteLine($"Customers, which have orders with sum more than {x}: ");
                sw.WriteLine("");
                foreach (var someCustomer in customers)
                {
                    sw.WriteLine(someCustomer);
                }
            }
        }

        public void TotalTurnoverMoreThanX(int x)
        {
            getCustomers = new GetSortedCustomers();
            var customers = getCustomers.GetCustomersWithTurnoverMoreX(x);

            using (StreamWriter sw = new StreamWriter(Settings1.Default.TotalTurnoverMoreThanX, false, System.Text.Encoding.Default))
            {
                sw.WriteLine($"Customers, whose total turnover (sum of all orders) exceeds the value of {x}: ");
                sw.WriteLine("");
                foreach (var someCustomer in customers)
                {
                    sw.WriteLine(someCustomer);
                }
            }
        }

        public void MonthAndYearFirstOrder()
        {
            getCustomers = new GetSortedCustomers();
            var customersWithDate = getCustomers.GetCustomersWithDateFirstOrder();


            using (StreamWriter sw = new StreamWriter(Settings1.Default.MonthAndYearFirstOrder, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Month and year of first order of each customer: ");
                sw.WriteLine("");
                foreach (var someCustomer in customersWithDate)
                {
                    sw.WriteLine(someCustomer);
                }
            }
        }

        public void GroupByCountries()
        {
            getCustomers = new GetSortedCustomers();
            var customersSorted = getCustomers.GetCustomersSortedByCountry();

            using (StreamWriter sw = new StreamWriter(Settings1.Default.SortByCountries, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Customers, sorted by country: ");
                foreach (var sortedCustomer in customersSorted)
                {
                    sw.WriteLine(sortedCustomer);
                }
            }
        }

        public void SortedMonthAndYearFirstOrder()
        {
            getCustomers = new GetSortedCustomers();
            var customersSortedByMonth = getCustomers.GetCustomersSortedByMonth();
            var customersSortedByYear = getCustomers.GetCustomersSortedByYear();

            using (StreamWriter sw = new StreamWriter(Settings1.Default.SortedMonthAndYearFirstOrder, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Month and year of first order of each customer, sorted by month: ");
                sw.WriteLine("");
                foreach (var someCustomer in customersSortedByMonth)
                {
                    sw.WriteLine(someCustomer);
                }
                sw.WriteLine("");
                sw.WriteLine("Month and year of first order of each customer, sorted by year: ");
                sw.WriteLine("");
                foreach (var someCustomer in customersSortedByYear)
                {
                    sw.WriteLine(someCustomer);
                }
            }
        }
    }
}
