using System.Collections.Generic;

namespace Serialization
{
    public static class BooksToAdd
    {
        public static List<Book> GetAllBooks()
        {
            var books = new List<Book>();

            books.Add(new Book(
               "bk101",
               "0-596-00103-7",
                "Löwy, Juval",
                "COM and .NET Component Services",
                Genre.Computer,
                "O'Reilly",
                "2001-09-01",
                " COM & .NET Component Services provides both traditional COM programmers and new .NET " +
                              "component developers with the information they need to begin developing applications that take full advantage of COM+ services. " +
                              "This book focuses on COM+ services, including support for transactions, queued components, events, concurrency management, and security",
               "2016-01-05"
            ));
             books.Add(new Book(
                "bk102",
                null,
                "Ralls, Kim",
                "Midnight Rain",
                Genre.Fantasy,
                "R & D",
                "2000-12-16",
                " A former architect battles corporate zombies," +
                              "an evil sorceress, and her own childhood to become queen" +
                              "of the world.",
                 "2017-01-01"));
            books.Add(new Book(
                "bk103",
                 null,
               "Corets, Eva",
                "Maeve Ascendant",
                Genre.Fantasy,
                "R & D",
                "2000-11-17",
                " After the collapse of a nanotechnology" +
                              "society in England, the young survivors lay the" +
                              "foundation for a new society.",
                "2016-01-05"
            ));
            books.Add(new Book(      
                "bk104",
                 null,
                "Corets, Eva",
                "Oberon's Legacy",
                Genre.Fantasy,
                "R & D",
                "2001-03-10",
                " In post-apocalypse England, the mysterious" +
                              "agent known only as Oberon helps to create a new life" +
                              "for the inhabitants of London.Sequel to Maeve" +
                              "Ascendant.",
                "2012-03-01"
            ));
            books.Add(new Book(
                 "bk105",
                  null,
                "Corets, Eva",
               "The Sundered Grail",
                Genre.Fantasy,
                "R & D",
                "2001-09-10",
                " The two daughters of Maeve, half-sisters," +
                              "battle one another for control of England.Sequel to" +
                              "Oberon's Legacy.",
                "2016-01-05"
            ));
            books.Add(new Book(
                "bk106",
                 null,
                "Randall, Cynthia",
                 "Lover Birds",
                 Genre.Romance,
                "R & D",
                "2000-09-02",
                " When Carla meets Paul at an ornithology" +
                              "conference, tempers fly as feathers get ruffled.",
                "2016-01-05"
            ));
           books.Add(new Book(
                 "bk107",
                  null,
                 "Thurman, Paula",
                 "Splish Splash",
                Genre.Romance,
                 "R & D",
                "2000-11-02",
                " A deep sea diver finds true love twenty" +
                              "thousand leagues beneath the sea.",
                "2012-01-05"
            ));
            books.Add(new Book(
                "bk108",
                 null,
                "Knorr, Stefan",
                "Creepy Crawlies",
                 Genre.Horror,
                "R & D",
                "2000-12-06",
                " An anthology of horror stories about roaches," +
                              "centipedes, scorpions  and other insects.",
                "2011-01-05"
            ));
            books.Add(new Book(
                "bk109",
                 null,
                "Kress, Peter",
                 "Paradox Lost",
                 Genre.ScienceFiction,
                "R & D",
                 "2000-11-02",
                " After an inadvertant trip through a Heisenberg" +
                              "Uncertainty Device, James Salway discovers the problems" +
                              "of being quantum.",
                "2016-01-05"
            ));
            books.Add(new Book(
                "bk110",
                 null,
                "O'Brien, Tim",
                 "Microsoft .NET: The Programming Bible",
                 Genre.Computer,
                "R & D",
                "2000-12-09",
                " Microsoft's .NET initiative is explored in" +
                              "detail in this deep programmer's reference.",
                "2014-10-01"
            ));
            books.Add(new Book(
                "bk111",
                 null,
                "O'Brien, Tim",
                "MSXML3: A Comprehensive Guide",
                Genre.Computer,
                "Microsoft",
                "2000-12-01",
               " The Microsoft MSXML3 parser is covered in" +
                              "detail, with attention to XML DOM interfaces, XSLT processing," +
                              "SAX and more.",
                "2010-03-15"
            ));
            books.Add(new Book(
                 "bk112",
                  null,
                "Galos, Mike",
                "Visual Studio 7: A Comprehensive Guide",
                Genre.Computer,
                "Microsoft",
                "2001-04-16",
                " Microsoft Visual Studio 7 is explored in depth," +
                              "looking at how Visual Basic, Visual C++, C#, and ASP+ are" +
                              "integrated into a comprehensive development" +
                              "environment.",
                "2011-04-25"
            ));
            
            return books;
        }
    }
}