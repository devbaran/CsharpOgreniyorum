using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());


            
        }

        private static void NewMethod()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { ID = 1, FirstName = "Memduh", LastName = "Kurtboğgan", Adress = "Batman" });



            Student student = new Student() { ID = 2, FirstName = "Orhun", LastName = "Kurtbogan", Departmant = "aymm" };
            manager.Add(student);
        }
    }
    interface IPerson //soyut nesne, tek başına işe yaramaz, diğer classlara inheritance yapacağız ki 
        //Ipersonda tanımlanan herşey bu sayede classlarda gözükecektir...
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson // somut nesne
    /*IPersonda yazılan özellikler veya metodlar, 
    onu implemente eden classın içinde yani customer ve student içerisinde yazılmalı,tanımlanmalıdır. */
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }
    class Student : IPerson // somut nesne
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        } 
    }
}
