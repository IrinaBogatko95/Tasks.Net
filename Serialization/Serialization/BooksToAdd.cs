using System.Collections.Generic;

namespace Serialization
{
    public static class BooksToAdd
    {
        public static IEnumerable<Book> GenerateBooks()
        {
            var books = new List<Book>
            {
                new Book
                {
                    Id = "bk101",
                    Author = "Löwy, Juval",
                    Isbn = "0-596-00103-7",
                    Title = "COM and .NET Component Services",
                    Genre = Genre.Computer,
                    Publisher = "O'Reilly",
                    PublishDate = "2001-09-01",
                    Description = " COM & .NET Component Services provides both traditional COM programmers and new .NET " +
                                  "component developers with the information they need to begin developing applications that take full advantage of COM+ services. " +
                                  "This book focuses on COM+ services, including support for transactions, queued components, events, concurrency management, and security",
                    RegistrationDate = "2016-01-05"
                },
                new Book
                {
                    Id = "bk102",
                    Author = "Ralls, Kim",
                    Title = "Midnight Rain",
                    Genre = Genre.Fantasy,
                    Publisher = "R & D",
                    PublishDate = "2000-12-16",
                    Description = " A former architect battles corporate zombies," +
                                  "an evil sorceress, and her own childhood to become queen" +
                                  "of the world.",
                    RegistrationDate = "2017-01-01"
                },
                new Book
                {
                    Id = "bk103",
                    Author = "Corets, Eva",
                    Title = "Maeve Ascendant",
                    Genre = Genre.Fantasy,
                    Publisher = "R & D",
                    PublishDate = "2000-11-17",
                    Description = " After the collapse of a nanotechnology" +
                                  "society in England, the young survivors lay the" +
                                  "foundation for a new society.",
                    RegistrationDate = "2016-01-05"
                },
                new Book
                {
                    Id = "bk104",
                    Author = "Corets, Eva",
                    Title = "Oberon's Legacy",
                    Genre = Genre.Fantasy,
                    Publisher = "R & D",
                    PublishDate = "2001-03-10",
                    Description = " In post-apocalypse England, the mysterious" +
                                  "agent known only as Oberon helps to create a new life" +
                                  "for the inhabitants of London.Sequel to Maeve" +
                                  "Ascendant.",
                    RegistrationDate = "2012-03-01"
                },
                new Book
                {
                    Id = "bk105",
                    Author = "Corets, Eva",
                    Title = "The Sundered Grail",
                    Genre = Genre.Fantasy,
                    Publisher = "R & D",
                    PublishDate = "2001-09-10",
                    Description = " The two daughters of Maeve, half-sisters," +
                                  "battle one another for control of England.Sequel to" +
                                  "Oberon's Legacy.",
                    RegistrationDate = "2016-01-05"
                },
                new Book
                {
                    Id = "bk106",
                    Author = "Randall, Cynthia",
                    Title = "Lover Birds",
                    Genre = Genre.Romance,
                    Publisher = "R & D",
                    PublishDate = "2000-09-02",
                    Description = " When Carla meets Paul at an ornithology" +
                                  "conference, tempers fly as feathers get ruffled.",
                    RegistrationDate = "2016-01-05"
                },
                new Book
                {
                    Id = "bk107",
                    Author = "Thurman, Paula",
                    Title = "Splish Splash",
                    Genre = Genre.Romance,
                    Publisher = "R & D",
                    PublishDate = "2000-11-02",
                    Description = " A deep sea diver finds true love twenty" +
                                  "thousand leagues beneath the sea.",
                    RegistrationDate = "2012-01-05"
                },
                new Book
                {
                    Id = "bk108",
                    Author = "Knorr, Stefan",
                    Title = "Creepy Crawlies",
                    Genre = Genre.Horror,
                    Publisher = "R & D",
                    PublishDate = "2000-12-06",
                    Description = " An anthology of horror stories about roaches," +
                                  "centipedes, scorpions  and other insects.",
                    RegistrationDate = "2011-01-05"
                },
                new Book
                {
                    Id = "bk109",
                    Author = "Kress, Peter",
                    Title = "Paradox Lost",
                    Genre = Genre.ScienceFiction,
                    Publisher = "R & D",
                    PublishDate = "2000-11-02",
                    Description = " After an inadvertant trip through a Heisenberg" +
                                  "Uncertainty Device, James Salway discovers the problems" +
                                  "of being quantum.",
                    RegistrationDate = "2016-01-05"
                },
                new Book
                {
                    Id = "bk110",
                    Author = "O'Brien, Tim",
                    Title = "Microsoft .NET: The Programming Bible",
                    Genre = Genre.Computer,
                    Publisher = "R & D",
                    PublishDate = "2000-12-09",
                    Description = " Microsoft's .NET initiative is explored in" +
                                  "detail in this deep programmer's reference.",
                    RegistrationDate = "2014-10-01"
                },
                new Book
                {
                    Id = "bk111",
                    Author = "O'Brien, Tim",
                    Title = "MSXML3: A Comprehensive Guide",
                    Genre = Genre.Computer,
                    Publisher = "Microsoft",
                    PublishDate = "2000-12-01",
                    Description = " The Microsoft MSXML3 parser is covered in" +
                                  "detail, with attention to XML DOM interfaces, XSLT processing," +
                                  "SAX and more.",
                    RegistrationDate = "2010-03-15"
                },
                new Book
                {
                    Id = "bk112",
                    Author = "Galos, Mike",
                    Title = "Visual Studio 7: A Comprehensive Guide",
                    Genre = Genre.Computer,
                    Publisher = "Microsoft",
                    PublishDate = "2001-04-16",
                    Description = " Microsoft Visual Studio 7 is explored in depth," +
                                  "looking at how Visual Basic, Visual C++, C#, and ASP+ are" +
                                  "integrated into a comprehensive development" +
                                  "environment.",
                    RegistrationDate = "2011-04-25"
                }
            };

            return books;
        }
    }
}