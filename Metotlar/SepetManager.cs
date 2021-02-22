using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme
        //syntax -yazım şekilleri
        public void Ekle(Urun urun) //bir yerde normal bir parantez görürsen orada bir metot çalışıyor c# için geçerli
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunadi, string urunaciklamasi, double fiyati, int stokadedi)
        {
            Console.WriteLine("Sepete eklendi: " + urunadi);
        }
    }
}
