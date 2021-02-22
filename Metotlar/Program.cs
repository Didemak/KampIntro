using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler) //urunler dizisini tek tek geziyor //en soldaki veri tipi
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("---------------Metotlar-----------------");

            //instance - örnek
            //encapsulation -Kapsulleme - ayrı ayrı yazmak yerine armuttaki gibi kapsülleyerek yazıyoruz classa yazdığımız gibi

            SepetManager sepetManager = new SepetManager(); //class ı çağırdık.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 8);   // stok adedi istediğinde metodumuza stok adedinide eklicez
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);      // ama bu sefer buralar patlıcak bu yüzden bu şekildeyazmak doğru değiil
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 9); // onun yerine classdaki özelliğe stok ekledik ve ürünlere çağırarak ekledik

        }
    }
}



//Dont repeat yourself - tekrar etme -clean code - best practice

