using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //ana krediManager classındaki hesapla fonksiyonunu kullanmak adına : Kredimanager olarak inheritance veriyoruz
    class KonutKrediManager : IKrediManager // ampule tıklayıp Implement Interface dediğimiz zaman aşağıdaki metodları getirecek, şablonu oturtacak.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandi");
        }
    }
}
