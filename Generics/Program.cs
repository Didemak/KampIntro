using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string,int> sehirler = new List<string,int>(); //stringin içine int yazsaydın int olarak parametreyi verecektin
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); // array bazlı oldukları için arka planda bir array yönetiyor // burası şu an sıfırdır
       

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);//count oluşturduk artık kaç elemanlı olduğunu yazırıcak
       
        }
    }ggfffffffftrtrtr

    class MyList<T> //random bir şey de yazabilirsin sadece tip kullanıcağımı belirtmek için bir şey yazdım                      //GENERICS CLASS 
    {
        T[] _array; //kendi listime de array eklicem
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; // sıfır elemanlı bir array oluşturdum //mylist i newlwndiğinde burasıda çalışcak ama default olarak o yüzden ctor kullandık. //yani ark planda çalışacak
        }
        public void Add(T item)
        {
            _tempArray = _array; //datalarımın uçmaması için bir yere yedeğini aldım
            _array = new T[_array.Length + 1]; // her eleman sayısını eklediğinde newlememiz için oluşturduk //eklicek sonra new yapıcak
            for (int i = 0; i <_tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; //aktarma işlemi burada yapılıyor
            }
            _array[_array.Length - 1] = item; //array bir arttığı için geri doldurduğumuzda son kutu boş kalıcak onuda item olarak dolduruyoruz.
        }
     

        public int Count       //şehirler2 nin countunu alabilmek için bunu oluşturduk //propfull dan oluşturduk
        {
            get { return _array.Length; }
   
        }

    }
}
