using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //bu süreç veritabanına loglama yapacak şekilde tasarlandı.
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
