using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Üç tane müşteri bulacak.
            //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.


            Musteri musteri1 = new Musteri();
            musteri1.TCKIMLIK = 1234567890;            
            musteri1.ID = 1;
            musteri1.Isim = "Mustafa";
            musteri1.SoyIsim = "Giden";

            Musteri musteri2 = new Musteri();
            musteri2.TCKIMLIK = 6723898091;
            musteri2.ID = 2;
            musteri2.Isim = "Nazmi";
            musteri2.SoyIsim = "Gidenoğulları";

            Musteri musteri3 = new Musteri();
            musteri3.TCKIMLIK = 4379214560;
            musteri3.ID = 3;
            musteri3.Isim = "Dilek";
            musteri3.SoyIsim = "Özdemir";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine(musteri.TCKIMLIK);
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.Isim);
                Console.WriteLine(musteri.SoyIsim);
                Console.WriteLine();
            }

            MusteriManager.MusteriEkle(musteri1);   //Static metotlarda direkt class ismi ile çağıralabilir.
            MusteriManager.MusteriEkle(musteri2);
            MusteriManager.MusteriEkle(musteri3);
            
            Console.WriteLine();
            
            MusteriManager musteriManager = new MusteriManager();  //MusteriManager'in objesi
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
            
            Console.WriteLine();
            
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
        }   
    }
}
