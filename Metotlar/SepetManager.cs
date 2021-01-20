using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //Manager demek bunlar bir operasyon tutuyor demektir.
    class SepetManager
    {

        //naming convention:yani E büyük olmalı. Metotlar pythondaki "def" ile tanımlanıyordu burda da public void ile oluyor. 
        // syntax
        public void Ekle(Urun urun)          // '()'-normal parantez varsa orda metot vardır.
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: "+urun.Adi );
        }


        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: "+urunAdi);
        }
    }
}
