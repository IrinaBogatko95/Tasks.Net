using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Catalog
    {
        public string Book { get; set; }
        public DateTime Date { get; set; }

        public Catalog()
        { }

        public Catalog(string book, DateTime date)
        {
            Book = book;
            Date = date;
        }
    }
}
