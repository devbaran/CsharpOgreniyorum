using System;

namespace Interfacesss
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();


            IPersonManager employeeManager = new EmployeeManager();

            IPersonManager internManager = new InternManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager); // aynı fonksiyona hem employee hem customer gönderdik ...
            projectManager.Add(customerManager);
            projectManager.Add(internManager); // intern sonradan eklendi ancak düzen bozulmadan direkt çalıştırabildik...
        }
    }
    //interface'ler new'lenemez! içi boş neyi newliyoruz :'(
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
            
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
    class ProjectManager
    {
        /*AddCustomer ve AddEmployee olarak iki fonksiyon oluşturup hangisi gerekliyse onu kullanmayı seçmek yerine direkt interface istenir,
         interface zaten Customer ve Employee değerlerini tutabilir, hangisini verirsek onun işlevi yerine getirilir.
        İki metod yerine tek metodla halletmiş oluruz*/ 
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }
}
