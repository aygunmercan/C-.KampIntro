using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği: veri türü ne ise önüne yazarsın
            // Do not repeat yourself

            string kategoriEtiketi = "Kategori"; //bir satır bitince ; koyarsın
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            
            
            
            
            
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}
