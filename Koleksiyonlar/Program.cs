using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };  //burda array(dizi) oluşturduk, 4 elemanlı ve biz buna yenisini ekleyemeyiz, sınırlıdır.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };   //listeler genişletiebilir ve bunu "using System.Collections.Generic;" eklemek gerekir.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);

            //listeler olmasaydı biz kendi koleksiyonumuzu nasıl oluştururuz? Bu da GenericsIntro projesi içerisinde Ordan devam et Pleaseeee!






        }
    }
}
