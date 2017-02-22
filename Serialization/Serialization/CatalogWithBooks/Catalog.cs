using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
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
            var xmlSerialiser = new XmlSerializer(typeof(Catalog));
            xmlSerialiser.Serialize(new XmlTextWriter(filePath, Encoding.UTF8), this, namespaces);
        }

        public static Catalog Deserialise(string filePath)
        {
            var xmlSerialiser = new XmlSerializer(typeof(Catalog));
            return (Catalog)xmlSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}