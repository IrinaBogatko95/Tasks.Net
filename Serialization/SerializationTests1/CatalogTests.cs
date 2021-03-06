﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serialization;
using SerializationTests1;
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
            catalog.Serialise(Path.Default.SerializationPath);
        }

        [TestMethod()]
        public void DeserialiseTest()
        {
            var catalog = Catalog.Deserialise(Path.Default.PathToDeserialize);
        }
    }
}