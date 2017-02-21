using Task_3_LinqToXml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3_LinqToXml.Tests
{
    [TestClass()]
    public class SorterXmlTests
    {

        [TestMethod()]
        public void OrderMoreThanXTest()
        {
            var sorterXml = new SorterXml();
            sorterXml.OrderMoreThanX(10000);
        }

        [TestMethod()]
        public void GroupByCountriesTestTest()
        {
            var sorterXml = new SorterXml();
            sorterXml.GroupByCountries();
        }

        [TestMethod()]
        public void MonthAndYearFirstOrderTestTest()
        {
            var sorterXml = new SorterXml();
            sorterXml.MonthAndYearFirstOrder();
        }

        [TestMethod()]
        public void TotalTurnoverMoreThanXTestTest()
        {
            var sorterXml = new SorterXml();
            sorterXml.TotalTurnoverMoreThanX(20000);
        }

        [TestMethod()]
        public void SortedMonthAndYearFirstOrderTest()
        {
            var sorterXml = new SorterXml();
            sorterXml.SortedMonthAndYearFirstOrder();
        }

        [TestMethod()]
        public void CustomersWithInvalidDataTest()
        {
            var sorterXml = new SorterXml();
            sorterXml.CustomersWithInvalidData();
        }
    }
}