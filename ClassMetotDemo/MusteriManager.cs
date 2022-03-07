using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
    
        public static void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} kişisi başarıyla eklendi",musteri.Isim,musteri.SoyIsim);
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("{0} numaralı ID başarıyla sıralandı.",musteri.ID);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("{0} {1} kişisi başarıyla çıkarıldı.", musteri.Isim,musteri.SoyIsim);
        }
    }
}
