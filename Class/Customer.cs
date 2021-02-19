using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        /* get ve set terimleri nereden gelir, bir propa tanım yaparken örnek olarak 
         * FirstName propuna Baran tanımlarken bunu SET etmiş oluyoruz, ek olarak bu tanımladığımız Baran propunu
         * kullanırken veya görmek için kullanmaya çalışırken bunu GET etmiş oluyoruz...
        */




        // get ve setler alınan veriyi işlerken değiştirmek için de kullanılabilir.
        private string _tcNo; // değişken tanımladık
        public string TcN
        {
            get { return "Tc Numara: " + _tcNo; }
            set { _tcNo = value; }
        }
        /* set ile aldığımız tc yi _tcNo değişkenine atadık, GET ederken 
         yani kullanırken başına Tc Numara: ibaresi getirdik bu sayede işlemiş olduk ancak bu kısım
        nadiren kullanılan bir yoldur, genellikle üst kısımda bulunan prop tiplerini kullanacağız,
        bu tarz kullanımlar artık geçmişte kaldı ... */




    }
}
