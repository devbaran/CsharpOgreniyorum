using System;

namespace Inheritance
{
    class Program
    {
        //interface'ler inheritence olarak görülebilir ancak o bir implementasyondur, ancak inheritance gibi de kullanılırlar..
        //biraz daha temel inheritance öğrenelim....
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Orhan" }, new Student{FirstName="Rezan" }, new Person{FirstName="Baran" },
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
            
        }
    }
    class Person
        //Interface'ler tek başına anlam ifade etmez, ancak burada class tek başına birşey ifade edebilir.
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Person2 // bir interface birden fazla implementasyon yapabilirken; classlar tek sefer inheritance olur
        /* yani person 2 başka bir classa İKİNCİ OLARAK kalıtım veremez.... her classın bir babası olur gibi düşünülebilir...*/
    {

    }
    class Customer:Person // Customer tanımlanmadığı halde Person'dan gelen özellikleri inheritance sayesinde taşıyacaktır...
    {
        public string City { get; set; } // ancak istenirse Person'dan bağımsız birkaç daha prop tanımlanabilir...

    }
    class Student:Person
    {
        public string Department { get; set; }

    }
}
