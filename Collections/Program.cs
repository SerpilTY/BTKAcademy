using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();
            // List();

            Dictionary<string, string> dictionary =
                new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

           Console.WriteLine( dictionary.ContainsKey("glass"));

            static void List()
            {
                List<string> cities = new List<string>();
                cities.Add("Ankara");
                cities.Add("İzmir");

                Console.WriteLine(cities.Contains("Ankara"));

                foreach (var item in cities)
                {
                    Console.WriteLine(
                        item);
                }

                /*  List<Customer> customers = new List<Customer>();
                  customers.Add(new Customer {Id=1,FirstName="Engin" });
                  customers.Add(new Customer { Id = 2, FirstName = "Duru" });
                */

                List<Customer> customers = new List<Customer> {
             new Customer {Id=1,FirstName="Engin" },
             new Customer  {Id=2,FirstName="Duru" }


            };



                var customer = new Customer
                {
                    Id = 3,
                    FirstName = "Serpil"
                };

                customers.Add(customer);
                customers.AddRange(new Customer[2]
                { new Customer{Id=4, FirstName="Ali"},
            new Customer{Id=5,FirstName="Ahmet"}}
                );

                //customers.Clear();

                Console.WriteLine(customers.IndexOf(customer));

                customers.Add(customer);
                Console.WriteLine(customers.LastIndexOf(customer));

                customers.Insert(0, customer);

                customers.Remove(customer);



                Console.WriteLine(customers.Contains(customer));

                var count = customers.Count;
                Console.WriteLine("Count= " + count);

                foreach (var item in customers)
                {
                    Console.WriteLine(item.FirstName);
                }
            }

            static void ArrayList()
            {
                ArrayList cities = new ArrayList();
                cities.Add("Ankara");
                cities.Add("İstanbul");

                foreach (var item in cities)
                {
                    Console.WriteLine(item);
                }
            }
        }
            class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
        }
    }

