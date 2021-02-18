using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //INTERFACE'leri birbirinin alternatifi olan AMA kod içerikleri farklı olan durumlar için kullanırız
    //metod aynı ancak hesaplama şekilleri değişkenlik gösterirse kullanılır
    interface IKrediManager //I harfi ile başlatılır, interface oldugu anlasilsin.
        /*aşağıdaki tek hesapla fonksiyonları diğer kredi türlerinde alternatif hesaplamalar yapmalıdır
        ve tek başına yetersiz olacaktır, bu tarz durumlarda base CLASS yerine INTERFACE kullanılır ...*/
    {
        void Hesapla(); // süslü parantezler silinir interface methodlarında
        void BiseyYap();
        //artık hesapla ve biseyYap bütün kredilerde olması gereken metodlardır, zorunludur.
        //interface şablon arayüz demektir, burada bulunan şablona dieğr claslarda uyulmalıdır.
        
        
    }
}
