using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //claslar özellik ve operasyon tutarlar. Özellik tutuyorsak operasyon tutmuyoruz, operasyon tutuyorsak Özellik tutmuyoruz.
    // eğerki bir nesnede bir değeri kullanma zorunluluğun yok gibi görünüyorsan orada soyutlama hatası yapıyorsundur. Mesela şahıs bir şirket değil SirketAdi da olamaz.
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
