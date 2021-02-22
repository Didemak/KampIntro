using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Ömer";
            Employee employee = new Employee();
            employee.FirstName = "Didem";

            //customer = employee; //ikisini atayamazsın 
            Person person3 = customer; //bunları atarsınız çünkü miras aldığınız sınıfı atayabilirsiniz
            Console.WriteLine(person3.FirstName);//customerı peron3 e atadım ve customera first name verdim Ömer person3 de Ömer oldu


            customer.CreditCardNumber = "134567890";
            Console.WriteLine(((Customer)person3).CreditCardNumber);//customerın içerisinde person classı bulunuyor ancak person un içerisinde ıd firstName ve LastName bulunuyor. 
                                                                    //Biz person a customerdaki CreditCardı eklemek için bunu kullanıyoruz ve çıkıyor


            PersonManager personManager = new PersonManager();
            personManager.Add(customer); //gördüğünüz gibi 3 ünde de sorunçıkmadı çünkü person customer ve employee nin base i
            personManager.Add(employee);
            personManager.Add(person3);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class:Person
    class Customer : Person //customerın içinde person var //Inheritance
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person //Employee nin içinde person var
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) // (Customer customer) yapsam sadece customeri alcak (Employee employee) yapsam sadece employee yi alcak o yüzden (Person person) yaptık.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
