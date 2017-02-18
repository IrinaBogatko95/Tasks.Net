using NUnit.Framework;
using Serialization;

namespace Tests
{
    [TestFixture]
    public class BooksCatalogSerialisation
    {
        [Test]
        public void SerialisationTest()
        {          
            var catalog = new Catalog();
            catalog.Serialise(Settings1.Default.SerializationPath);
        }

        [Test]
        public void DeseroalisationTest()
        {
            var catalog = Catalog.Deserialise(Settings1.Default.PathToDeserialize);
        }
    }
}