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
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlElement("book")]
        public List<Book> Books { get; set; }

        private DateTime date;

        [XmlAttribute("date")]
        public string Date
        {
            get { return Convert.ToDateTime(date).ToString("2016-02-05"); }
            set { date = DateTime.Parse(value); }
        }

        public Catalog()
        {
             Books = BooksToAdd.GetAllBooks();    
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