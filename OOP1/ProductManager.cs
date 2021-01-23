using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)       // void: emir kipinde git ekle, güncelle falan dedik. İşlem sonucunda ekstra bir bilgiye ihtiyacım yok.
        {
            Console.WriteLine(product.ProductName+" eklendi..");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi..");
        }

        //public int Topla(int sayi1, int sayi2)      //return ile sonucu kullanabiliriz biz.
        //{
        //    return sayi1 + sayi2;
        //}


        //public void Topla2(int sayi1, int sayi2)      //void sadece ekrana bastırır sonucu kullanamayız. Zaten void'de return yazılmaz.
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}


        //public void BirseyYap(int sayi)
        //{
        //    sayi = 99;
        //}

    }
}
