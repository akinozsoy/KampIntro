using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Akın";
            customer1.LastName = "Özsoy";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Kobe";
            customer3.LastName = "Bryant";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("Müşteriler Eklendi");
            Console.WriteLine(" ");

            customerManager.List();
            Console.WriteLine("Müşteriler Listelendi");
            Console.WriteLine(" ");
            
            customerManager.Remove(customer1);
            customerManager.Remove(customer2);
            customerManager.Remove(customer3);
        }
    }
}
