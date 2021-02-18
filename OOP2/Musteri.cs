using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        public int Id { get; set; } //eng: CustomerId
        public string MusteriNo { get; set; } //eng: CustomerNumber
        //Müşteri classı ebeveyndir, ortak olan kısımları buraya yazarız 
        /* ancak tüzelde sadece tüzelde olabilecek özellikler (şirket adı vergi no gibi.), 
            gerçekte de sadece ona ait olacak özellikler bulunur. 
            Böylece inheritance mantığıyla birbirleriyle bağlantılı ve daha mantıklı olacak şekilde çalışırlar */ 


        /* TC ve Vergi numaraları sayılardan oluşur, long yapmak yerine neden string yapıyoruz?
          Eğer bir veri üzerinde matematiksel işlem yapılmıyorsa(toplama çıkarma vs.), sayı görevi verilmiyorsa, 
        metinsel olarak planlanması çok daha faydalı olacaktır. 

        ÖNEMLİ NOT: Eğer bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, o nesneye ait değilmiş gibi gözüküyorsa o alan;
        demek ki orada hata yapıyorsun. SOYUTLAMA HATASI yapıyorsun....
         */
    }
}
