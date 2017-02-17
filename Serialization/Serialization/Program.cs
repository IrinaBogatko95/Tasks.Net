using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    // класс и его члены объявлены как public
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // стандартный конструктор без параметров
        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2016, 05, 02);
            Catalog catalog = new Catalog("bk101", date);
            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));


            //// объект для сериализации
            //Person person = new Person("Tom", 29);
            //Console.WriteLine("Object created");

            // передаем в конструктор тип класса
            //XmlSerializer formatter = new XmlSerializer(typeof(Person));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("C:\\Users\\Iryna_Bahatka1\\Documents\\catalog.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, catalog);
            }

            //// десериализация
            //using (FileStream fs = new FileStream("C:\\Users\\Iryna_Bahatka1\\Documents\\persons.xml", FileMode.OpenOrCreate))
            //{
            //    Person newPerson = (Person)formatter.Deserialize(fs);

            //    Console.WriteLine("Object deserialised");
            //    Console.WriteLine("Name: {0} --- Age: {1}", newPerson.Name, newPerson.Age);
            //}

            Console.ReadLine();
        }
    }
}