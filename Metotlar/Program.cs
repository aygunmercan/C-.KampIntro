using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe-tip güvenli: çalışacağım veri tipini bana ver diyor
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");

            }

            Console.WriteLine("-----------------Metotlar------------------------");

            //instance- örnek oluşturduk. Class örneğini oluşturduk.
            //encapsulation

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1); //metodu çağırdık.
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,3);
        }
    }
}
