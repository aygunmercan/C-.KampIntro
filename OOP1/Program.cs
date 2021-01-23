using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;     //2 numara mobilyaya karşılık geliyor bu örnekte.
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitPrice = 35, ProductName = "Kalem,", UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



            //int, double,bool... > Değer tip   , değer tiplerde atamalar değeri üzerinden olur ve tüm bağlantılar kopar yani
            //diziler, class,abstract class, interface...>Referans Tip
            //Bellekte iki tane alan var. Stack ve Heap diye.
            //REferans Tipler her ikisini de kullanır, Değer tipler ise sadece Stack'i kullanır.

            //int sayi = 100;                     //sayi=100 olmasına rağmen biz bunu BirseyYap fonksiyonuna gönderdik. Orda 99'du ama yazdırdığmızda cevap 100'dür. Neden?
            //productManager.BirseyYap(sayi);     //Çünkü buraya sadece sayının değeri geldi. sayi ve 100 arasındaki bağlşantı koptu sanki şöyle oldu:productManager.BirseyYap(100)
            //Console.WriteLine(sayi);            //burda da yazdırdığında cw(100) olarak aldı içerde değişmedi yani.

            //Ama referans tiplerde atamalar bellekteki referans adresiyle yapılır.
            //productManager.Add(product1);
            //Console.WriteLine(product1.ProductName);    gibi bir örnekte içerden değişerek gelir.burda masa içerde kalemse buraya kalem olarak döner.




        }
    }
}
