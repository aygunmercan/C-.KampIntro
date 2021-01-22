using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Id:"+musteri.Id+",Ad:"+musteri.Ad+",Soyad:"+musteri.Soyad+",Yaş:"+musteri.Yas +",Maaş:"+musteri.Maas+ " bilgilerini içeren müşteri veri tabanına eklendi.\n");

        }


        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Id:" + musteri.Id + ",Ad:" + musteri.Ad + ",Soyad:" + musteri.Soyad + ",Yaş:" + musteri.Yas + ",Maaş:" + musteri.Maas + " bilgilerini içeren müşteri veri tabanından silindi.\n");

        }

        //public void Listele(Musteri musteri)
        //{
        //    Console.WriteLine(musteri.Id + " nolu," + Environment.NewLine + musteri.Ad + " adlı," + Environment.NewLine + musteri.Soyad + " soyadlı," + Environment.NewLine + musteri.Yas + " yaşlı," + Environment.NewLine + musteri.Maas + " maaşlı" + " müşteri veri tabanına eklendi.");

        //}

    }
}

