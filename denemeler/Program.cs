using System;
using System.Linq;

namespace denemeler
{
    class Program
    {
        // 16 OCAK ÖDEV!
        //METOTLAR YANİ FONKSİYONLAR İLE İLGİLİ ÖRNEKLER
        static void Main(string[] args)
        {
            //var x = Add(8);
            //Console.WriteLine(x);

            //int number1=20;           //out alternatifinde buna gerek yok.
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);       //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //Console.WriteLine(Multiply(2,4,5));
            //Console.WriteLine(Add4(1,2,3,4,4,5));
            
            
        }

        //static int Add(int sayi1, int sayi2=40) //default değer olarak 30 verdik)
        //{
        //    var result = sayi1 + sayi2; //mesela şu an var= int türünde oldu çünkü ilk çalıştığında böyle algıladı.//Var ile tanımlanan bir değişkene atanan ilk değer program derlendiği anda değişkenin veri türünü belirlemektedir
        //    return result;
        //}

        //static int Add3(ref int number1, int number2) //ref keywordü ile number1 e referans gönderiyoruz ve diyoruz ki: dışardan 20 gelse bile içerde 30 ise dışarı da 30 çıksın. in/out gibi düşün... 
        //{                                              // ref'in alternatifi out'tur . tek fark out'ta int number1=20 yazmak zorunda değiliz.
        //    number1 = 30;
        //    return number1 + number2;

        //}

        //static int Multiply(int number1, int number2)
        //{
        //    return number1 * number2;
        //}

        //static int Multiply(int number1, int number2,int number3)  //bu şekilde overload eedebiliriz yani yukardaki fonksiyonu genişletme, aşırı yükleme yapabiliriz 3 çarpanlı hale getirerek.
        //{
        //    return number1 * number2*number3;
        //}

        //static int Add4(params int[] numbers)     // params bir keyword ve birden fazla sayıyı toplamak için bunu kullanıyoruz mesela. Overload etcez ama daha bestpractice olarak...
        //{
        //    return numbers.Sum();         //dizideki tüm sayıları birbiriyle topla fonksiyonunu çağırdık.

        //}

    }
}
