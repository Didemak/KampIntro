using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            // veri ekliyoruz
            AdYas.Add("Didem", 21);
            AdYas.Add("Derya", 23);
            AdYas.Add("Gizem", 14);

            foreach (var degerOku in AdYas)
            {
                Console.WriteLine(degerOku);
            }

            //değer sayma özelliği
            Console.WriteLine(AdYas.Count + " eleman sayısı var");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Silindi");  //Silme işleme        
            AdYas.Remove("Gizem");
            foreach (var degerOku in AdYas)
            {
                Console.WriteLine(degerOku);
            }

        }
    }
}
