using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) //loglamak istedik
            /*Buraya IKrediManager gönderdik, bu sayede IKrediManager; taşıt ihtiyaç ve konut kredisinin
             base i olduğu için, hangi kredi türünü gönderirsek onun hesaplama fonksiyonu çalışacaktır.
            */
        {
            //bilgileri değerlendirelim ve kredi hesaplamasını burada yapalım...
            krediManager.Hesapla();
            loggerService.Log(); //hangi loglayıcı(db/file) seçildiyse, ona göre logla diyoruz, dinamik çalışıyoruz!!!
            //burada Method Injection  kullanıyoruz, hangi kredi türü veya hangi loglayıcı olacağını enjekte ediyoruz

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
            //bir liste istiyoruz, bu listenin türünü de IKrediManager olarak istiyoruz ki,
            //hem taşıt hem de konut kredisi bilgilendirmesi istenirse ikisini bir listede alıp iki sonucu aynı anda gösterelim
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
