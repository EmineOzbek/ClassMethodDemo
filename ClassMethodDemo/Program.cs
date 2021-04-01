using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 123;
            customer1.CustomerName = "Emine";
            customer1.CustomerLastName = "Özbek";
            customer1.CustomerPhoneNumber = "05987654321";

            Customer customer2 = new Customer();
            customer2.CustomerId = 456;
            customer2.CustomerName = "Fatma";
            customer2.CustomerLastName = "Uzun";
            customer2.CustomerPhoneNumber = "05987654320";

            Customer customer3 = new Customer();
            customer3.CustomerId = 789;
            customer3.CustomerName = "Ali";
            customer3.CustomerLastName = "Osman";
            customer3.CustomerPhoneNumber = "05123456789";

           
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            CustomerManager customerManager = new CustomerManager(); 
            
            customerManager.Add(customer1);
            customerManager.List(customers);
            customerManager.Delete(customer3);

        }
    }
}
