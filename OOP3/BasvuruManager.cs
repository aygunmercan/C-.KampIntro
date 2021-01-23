using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)//ILoggerService loggerService)   //krediManager interface olduğu için tüm kredi tiplerinin referanslarını tutuyor.
        {
            //Başvuran bilgilerini değerlendirme vb ile ilgili bilgileri alırız.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();    >>>>tüm başvurular konutkredisi üzerinden hesaplarız başvuruyu ama biz bunu istemiyoruz ki.

            krediManager.Hesapla();
            //loggerService.Log();
            foreach (var item in loggerServices)
            {
                item.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
