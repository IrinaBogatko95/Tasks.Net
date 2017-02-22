using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3_LinqToXml;

namespace Task_3_LinqToXml.Tests
{
    [TestClass()]
    public class SorterXmlTests
    {
        public static WritertoFile writerToFile;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
           writerToFile = new WritertoFile();
        }

        [TestMethod()]
        public void OrderMoreThanXTest()
        {
            writerToFile.OrderMoreThanX(10000);
        }

        [TestMethod()]
        public void GroupByCountriesTestTest()
        {
            writerToFile.GroupByCountries();
        }

        [TestMethod()]
        public void MonthAndYearFirstOrderTestTest()
        {
            writerToFile.MonthAndYearFirstOrder();
        }

        [TestMethod()]
        public void TotalTurnoverMoreThanXTestTest()
        {
            writerToFile.TotalTurnoverMoreThanX(20000);
        }

        [TestMethod()]
        public void SortedMonthAndYearFirstOrderTest()
        {
            writerToFile.SortedMonthAndYearFirstOrder();
        }

        [TestMethod()]
        public void CustomersWithInvalidDataTest()
        {
            writerToFile.CustomersWithInvalidData();
        }
    }
}