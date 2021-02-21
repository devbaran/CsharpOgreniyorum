using System;

namespace AgaOylesine
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculate dortEkle = new DortEkleManager();
            ICalculate ikiEkle = new IkiEkleManager();

            dortEkle.Hesapla();
            ikiEkle.Hesapla();
        }
    }
}
