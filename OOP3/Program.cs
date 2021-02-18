using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Console.WriteLine("DİĞER DENEME");
            //her birini tanımladık ancak hepsine aynı şekilde interface tanımlasaydık ta aynı sonucu verecekti, deneyelim;

            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            IKrediManager konutKrediManager1 = new KonutKrediManager();
            //INTERFACE'ler de o interface'i implemente eden classın REFERANS numarasını TUTABILIYOR!

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService(); //instance oluşturma ilk kullanımda gereklidir...

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager1,fileLoggerService); // veya file seçilir...
            //basvurumanager'a IKredimanager verdiğimiz için, her seçeneğin kendine özel başvuru ve hesaplama metodu çalışacaktır

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1,tasitKrediManager1,konutKrediManager1 };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); //yukarıdaki krediler listesini fonksiyonun içine gönderebiliyoruz ve ona göre çalışıyor
        }
    }
}
