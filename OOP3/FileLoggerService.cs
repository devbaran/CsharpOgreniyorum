using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService 
        //yukarıda database, burada File/Dosyaya loglandı. İki farklı alternatif oluşturduk classlar ile
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı"); //ikinci alternatifimiz
        }

    }
}
