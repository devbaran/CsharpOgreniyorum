using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> siparis = new Dictionary<int, string>();
            siparis.Add(3075, "Bezirci");
            siparis.Add(3070, "Heheh");
            siparis.Add(3085, "Warrior36");
            siparis.Add(3089, "Testere");

            Console.Write("No Giriniz: ");
            int x = int.Parse(Console.ReadLine()); //kullanıcından input veri girişi alma yöntemi......
            

            try
            {
                Console.WriteLine(siparis[x]);
            }
            catch
            {
                Console.WriteLine("Siparis bulunamadi");
            }

            /* Yukarıda key=sipariş numarası, value= siparişi teslim alanların kullanıcı isimleridir, verilen key bu dict içerisindeyse 
             * teslim alan bilgisi ekrana yazdırılacaktır, yani try kısmı çalışacaktır.
             * verilen sipariş no/ yani key; bu dict içinde değilse KeyNotFoundException şeklinde hata, try bloğundan çıkıp catch bloğuna yöneltecektir.
             * bu catch bloğunda sipariş bulunamadı yazacaktır...
              */
        }   
    }
}
