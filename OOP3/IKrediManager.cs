using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager   //interface: diğermanagerlar hesaplama işlemine ortak sahip olmak zorundalarsa bunu interface yapalım.Yani her kredide olması gereken 
                               //metotlar olacağı için bu interface yi kullanıyoruz.
    {                          // interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
                                //tüm kredilerde "Hesapla" vardır ama hesaplanış kodu farklıdır.
        void Hesapla();
        void BiseyYap();
    }
}
