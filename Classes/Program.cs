using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Serpil";
            customer.LastName = "Yüksel";
            customer.City = "İstanbul";
            customer.Id = 1;

            Customer customer2 = new Customer
            {

                Id = 2,
                City = "İzmir",
                LastName = "Yüksel",
                FirstName = "Zeynep Duru"


            };

            Console.WriteLine(customer2.FirstName);
        }

        
    }


 


   
}
