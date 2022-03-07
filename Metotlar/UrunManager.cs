using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class UrunManager
    {
    
        public void Ekle(Urun urun)     //Düzenli bir metot
        {

            Console.WriteLine("{0} Sepete {1} Türk lirasıyla ile birlikte Başarıyla Eklendi.",urun.Adi,urun.Fiyati);
        }
        public void Ekle2(string urunAdi,int urunFiyat,string urunAciklama,int stokAdedi)    
        {
            //Bu metot kullanılabilir fakat projelerde düzenlemelerde daha çok zamanınımız alır.
            Console.WriteLine("{0} Sepete Başarıyla Eklendi.", urunAdi);
        }
    
    
    }
}
