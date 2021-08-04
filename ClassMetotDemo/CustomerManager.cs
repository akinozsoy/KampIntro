using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer> { };
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Müşteri Başarıyla eklendi " + customer.FirstName + " " + customer.LastName );
        }
        public void Remove(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Müşteri başarıyla silindi "+customer.FirstName + " " + customer.LastName);
        }

        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("ID : "+customer.Id);
                Console.WriteLine("First Name : " + customer.FirstName);
                Console.WriteLine("Last Name : " + customer.LastName);
            }
        }
        
    }

}
