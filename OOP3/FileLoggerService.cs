using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        //bu süreç dosyaya loglama yapacak şekilde tasarlandı.
        public void Log()
        {
         
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
