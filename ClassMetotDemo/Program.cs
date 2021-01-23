using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = new Random().Next(1, 500);
            musteri1.Ad = "Merve";
            musteri1.Soyad = "Nur";
            musteri1.Yas = 45;
            musteri1.Maas = 6700;

            Musteri musteri2 = new Musteri();
            musteri2.Id = new Random().Next(1, 500);
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Kara";
            musteri2.Yas = 23;
            musteri2.Maas = 4500;



            Musteri musteri3 = new Musteri();
            musteri3.Id = new Random().Next(1, 500);
            musteri3.Ad = "Sema";
            musteri3.Soyad = "Gülbeyaz";
            musteri3.Yas = 59;
            musteri3.Maas = 3500;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

            int count = 1;
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (var item in musteriler)
            {
                Console.WriteLine("////////////" + count + ". müşteriye ait bilgiler/////////");
                Console.WriteLine("Id: " + item.Id + Environment.NewLine + "Ad Soyad: " + item.Ad + " " + item.Soyad + Environment.NewLine + "Yaş: " + item.Yas + Environment.NewLine + "Maaş: " + item.Maas + Environment.NewLine);
                count += 1;

            }

        }
    }
}