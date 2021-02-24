using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Dimiroğ", City="Ankara" };//1. //customer1.ıd=1 bunlar aynı kullanımdır
            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara"); //Normal parantez görürsniz metot mantığı vardır //2.
            Console.WriteLine(customer2.FirstName); //23. satırda atama işlemi yaptığım için yazdırdı.
            Console.WriteLine(customer1.Id);  
        }

        class Customer
        {
            public Customer() //1. //parametresi olmayanlar için oluşturduk. // default constructor: parametresi olmayana denir
            {
             
            }
            public Customer(int id,string firstName,string lastName,string city) //2. //parametresi olanlar için oluşturduk // sanki bir metotmuş gibi constructor bıraktık. parametre gibi çalışır //newleme yapınca bu blok çalışır
            {
                Id = id;                //Constructor da verdiğim parametreleri yazdırmak için önce hepsi için atama işlei yapmalıyım yoksa yazmaz.
                FirstName = firstName;
                LastName = lastName;
                City = city;

            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

        }
    }

}
