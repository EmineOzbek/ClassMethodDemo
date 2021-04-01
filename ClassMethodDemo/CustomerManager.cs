using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add (Customer customer)
        {
            Console.WriteLine("Eklendi!  :  " + customer.CustomerName + " " + customer.CustomerLastName );
        }

        public void List (Customer[] customers)
        {
            Console.WriteLine("    Müşteri Listesi:   ");
            foreach (Customer customer in customers)
            {
                
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastName);
            }
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine("Silindi!  :  " + customer.CustomerName + "  " + customer.CustomerLastName);
        }

    }
}
