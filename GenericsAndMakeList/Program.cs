using System;
using System.Collections.Generic;

namespace GenericsAndMakeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            

        }
    }

    class MyList<T> //artık bu bir generic class'tır
    {
        T[] _array;
        T[] _tempArray; // geçici dizi, newleyince oluşan kaybı önlemek adına
        public MyList() //constructor, ctor kısayol
        { // listemizin eleman sayısı burada belirlensin
            _array = new T[0]; // sıfır elemanlı bir array mevcut
        }
        public void Add(T item)
        {
            _tempArray = _array; // arrayin eski referans adresini temp array tutuyor
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)//temp arraydan eski değerleri tek tek alıyoruz
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item; //arrayLenght-1= açılan son yer, 4 elemanlı ise 3.indeks
            // yani 0 1 2 3.indeks =4.elemana karşılık gelir, oraya yeni sayımızı ekledik
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
