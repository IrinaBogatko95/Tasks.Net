using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlRootAttribute(Namespace = "http://library.by/catalog", IsNullable = true)]
    public class Catalog
    {
      //  [XmlElement("book")]
        public List<Book> books = new List<Book>();

        private DateTime date;

        [XmlAttribute]
        public string Date
        {
            get { return Convert.ToDateTime(date).ToString("yyyy-MM-dd"); }
            set { date = DateTime.Parse(value); }
        }

        public Catalog()
        {
            var books = BooksToAdd.GenerateBooks();
            this.books = books.ToList();
        }


        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void Serialise(string filePath)
        {
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "http://library.by/catalog");
            var catalogSerialiser = new XmlSerializer(typeof(Catalog));
            catalogSerialiser.Serialize(new XmlTextWriter(filePath, Encoding.UTF8), this, namespaces);
        }

        public static Catalog Deserialise(string filePath)
        {
            var catalogSerialiser = new XmlSerializer(typeof(Catalog));
            return (Catalog)catalogSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}