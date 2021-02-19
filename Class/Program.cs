using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer(); // prop classımızdan bir örnek yaptık....
            customer.City = "Batman";
            customer.Id = 1;
            customer.FirstName = "Memduh";
            customer.LastName = "Kurtboğan";

            Customer customer1 = new Customer { City = "Batman" ,FirstName="Baran", LastName="Kurtbogan",Id=1 };
            //bu şekilde prop kullanımı da mevcuttur...

            Console.WriteLine(customer1.FirstName); // c1'in adını yazdıralım

        }
    }

    //AŞAĞIDAKİ KISIMLAR DEVAMINDA DİĞER SEKMELERE EKLENDİ

    //class CustomerManager /* classlar ayrı olarak tanımlanır ancak biz burada tek sayfaya yazdık örnek amacıyla
    //    buradaki Manager olduğu için burası bir fonksiyon classıdır biz buradaki classın fonksiyonlarını 
    //    kullanmak istiyorsak yukarıda programın çalışacağı yerde onları bir kere örnek/ref. göstermeliyiz.*/
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Customer Added!");
    //    }
    //    public void Update()
    //    {
    //        Console.WriteLine("Customer Updated!");
    //    }
    //}
    //class ProductManager/* bir class daha tanımladık, temel anlamda biz yapacaklarımızı gruplandırmış olduk
    //                     üsteki classta customerlar hakkında işlemler yaparken burada product hakkında işlemler yapıyoruz
    //    aynı şekilde bunu da kullanmak için yukarıda  tanımlayalım...*/
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Product Added!");
    //    }
    //    public void Update()
    //    {
    //        Console.WriteLine("Product Updated");
    //    }
    //}
}
