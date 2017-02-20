using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Tests
{
    [TestClass()]
    public class CatalogTests
    {
        [TestMethod()]
        public void SerialiseTest()
        {
            var catalog = new Catalog();
            catalog.Serialise(Settings1.Default.SerializationPath);
        }

        [TestMethod()]
        public void DeserialiseTest()
        {
            var catalog = Catalog.Deserialise(Settings1.Default.PathToDeserialize);
        }
    }
}