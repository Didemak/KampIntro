using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "c#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.izlenmeorani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.izlenmeorani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.izlenmeorani = 80;

            //Kurs classından kurslar diye grup oluşturup 3 tane kurs belirledik.Bunu foreach de döndürürken kurs takma adını kullanarak kursları gezdik.
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Eğitmen);
            }

            //  Console.WriteLine(kurs1.Kursadi + " : " + kurs1.Eğitmen);
        }
    }
    class Kurs
    {
        public string Kursadi { get; set; }
        public string Eğitmen { get; set; }
        public int izlenmeorani { get; set; }
    }
}
//class oluşturuk ve classlara bir takım özellikler verdik. //Excel tablosunu düşün üst kısım özellikler.
//Daha sonra bu özellikleri doldurmak için Kurs kurs1 = new Kurs; diye değişkende tutuk ve bu kurs1 e eğitmenlerin bilgilerini doldurduk. //Alt kısım girilecekler.



