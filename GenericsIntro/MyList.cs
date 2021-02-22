using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {

        T[] items; //arka planda array tutuk //classın bütün elemanları erişsin diye en üste yazdık string items yerine T yazdık çünkü T tipini kullanıyoruz
                   // Ben bu arrayi newlemek zorundayım yoksa hata alırım.Bunun için constracter kullanırız
                   //constructoritems
        public MyList() //ctor tab tab yaptık //class ı bir yerden newlersem bu otomatik(constructor) çalışır // constructor olduğunu class la aynı isim olduğu için ordan anlarsın
        {
            items = new T[0]; // items ı burada newledik //oluşturdum ve elemanı sıfır olarak verdim.
        }
        public void Add(T item)
        {
            T[] tempArray = items;//items ı oluşturduğumuz geçici diziye verdik.Referans numarasını başkasına tuturduk
            items = new T[items.Length + 1]; //dizimin eleman sayısını 1 arttırıyotum.//her newlendiğinde bellektekiler uçacağı için bu bilgileri birine tuturmam lazım onun için bi üst satıra bak!
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //emaneten tempArray e verdiğim değerleri items a geri verdim
            }

            items[items.Length - 1] = item; //en son kutu boş kaldı o kutuya item ı yazdırdık.


        }

    }
}
