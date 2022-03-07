using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };        //Dizimiz(Our Array);

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
                Console.WriteLine();
            }
            Console.WriteLine("-----------Metotlar-----------");
            UrunManager urunManager = new UrunManager();
            urunManager.Ekle(urun1);             //Düzenli metot ile alakalıdır.
            urunManager.Ekle(urun2);
            Console.WriteLine("---------------------------");
            urunManager.Ekle2(urun1.Adi, urun1.Fiyati, urun1.Aciklama, 50);
            urunManager.Ekle2("Çilek",30,"ÇİLEK",100);   //Düzensiz içindir.
            urunManager.Ekle2(urun2.Adi,urun2.Fiyati,urun2.Aciklama,20);



        }
    }
}
