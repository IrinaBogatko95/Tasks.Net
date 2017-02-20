using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class Book
    {
        private DateTime publishDate;
        private DateTime registrationDate;

        [XmlAttribute("id")]
        public string Id { get; set; } 

       // [XmlElement("isbn")]
        //public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public string PublishDate
        {
            get
            { return publishDate.ToString("yyyy-MM-dd"); }
            set
            { publishDate = DateTime.Parse(value); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public string RegistrationDate
        {
            get
            { return registrationDate.ToString("yyyy-MM-dd"); }
            set
            { registrationDate = DateTime.Parse(value); }
        }

        public Book(string id, string author, string isbn, string title, Genre genre, string publisher,
            string publishDate, string description, string registrationDate)
        {
            this.Id = id;
           // this.Isbn = isbn;
            this.Author = author;
            this.Title = title;
            this.Genre = genre;
            this.Publisher = publisher;
            this.PublishDate = publishDate;
            this.Description = description;
            this.RegistrationDate = registrationDate;
        }

        public Book()
        {

        }

        private static DateTimeFormatInfo GetFormat()
        {
            var format = new DateTimeFormatInfo { DateSeparator = "-", ShortDatePattern = "yyyy-MM-dd" };
            return format;
        }
    }

    public enum Genre
    {
        Computer,
        Fantasy,
        Romance,
        Horror,

        [XmlEnum("Science Fiction")]
        ScienceFiction
    }
}