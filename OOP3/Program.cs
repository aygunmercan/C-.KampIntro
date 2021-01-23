using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //üstekiler çalışanın gördüğü ekran, seçim yapacağı.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();   //interfaca sayesinde başvuranın seçimini çalışan da seçer ve hesaplatır.
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });                  //databaseLoggerService); 
            //ya da şöyle yazabiliriz:basvuruManager.BasvuruYap(tasitKrediManager,new DatabaseLogger Service());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
