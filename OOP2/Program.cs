using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcN = "31234324234";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "005544888";




            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //base class olan müşteri iki diğer classı da tutabiliyor..

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            // olay burada Musteri base class'ın diğer classların referansını tutabilmesidir.

















            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcN = "321549871";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?"; 
            /*yukarıda bütün bilgiler müşteri classına tanımlandı tek başına.. ancak şirket adı müşteri ile alakalı değil
             bu tarzda tasarlanan ortamlar hatalıdır, zamanla şirket adı olan bireysel müşteriler, zamanla tc nosu olan tüzel müşteriler
             zamanla adı soyadı olan tüzel müşterilerle verilerle karşılaşılır, yanlışlıkla girilmiştir. 
            Gerçek-Tüzel , bunlar ikisi de müşteri, sırf birbirine benziyor diye birbirinin yerine kullanılamazlar, bilgi karmaşıklığı olacaktır
            SOLID yazılım geliştirme prensibi, L harfi bunu söylüyor...
            Doğrusu tek bir müşteri classı yerine gerçek ve tüzel müşteri olarak iki class oluşturmaktır. hemen başlayalım...*/
            }
    }
}
