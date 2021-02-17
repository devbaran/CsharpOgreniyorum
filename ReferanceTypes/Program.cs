using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Baran";
            
            person2 = person1;
            /* yukarıdaki işlemle referans adreslerini eşitlemiş olduk, artık p1 ve p2 değişkenlerinin tutulduğu yer aynı
             * o sebepe p1 e soyisim verdiğimizde, p2 ye soyisim vermemize gerek yok, çünkü adres ataması yaptık...
             */
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Memduh";
            customer.CreditCardNumber = "123123123";
            //burada kredi kartı numarası person'a da tanımlanmış olacaktır

            Employee employee = new Employee();
            employee.FirstName = "Veli";
            //base class person olduğu için customer ataması olabilir, ancak customer dan employee ataması olmaz...
            Person person3 = customer;
            customer.FirstName = "Ahmet"; // artık p3 ün de adı ahmet
            //aynı şekilde yine persona kredi kartı numarası da tanımlamış olduk....

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber); //burada personda da kredi kartı numarasını görmüş olduk
            //peki neden customera person diyelim? çünkü farklı classlara tek metod kullanmak için gerekebilir

            PersonManager personManager = new PersonManager();
            //tek classla bütün fonksiyonları kullandık
            //her bir farklı class için farklı metod yazmadık
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);


        }
    
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person //inheritance, person özelliklerini de veriyoruz 
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }


    }

    class PersonManager
    {
        //çoklu classlar için tek fonksiyon yazmış olduk, bu sayede bu fonksiyon her classtan değerimizi tutacaktır.
        //inheritance sağlayarak Person base class oldu, artık her değeri tutabilir...
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
