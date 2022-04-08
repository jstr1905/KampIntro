using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };//instance/örnek oluşturduk

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            Console.WriteLine(customer2.FirstName);//ilk başta gelmediği için Id=id City=city yazdık



        }


    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)//constructor metot gibi çalışır
        {
            Id = id;
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
