using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService:ILoggerService //sen aslında bir ILoggerService alternatifisin diyoruz...
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }

    }
}
