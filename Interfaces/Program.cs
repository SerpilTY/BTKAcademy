using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void NewMethod()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer
            {
                Id = 1,
                FirstName = "Serpil",
                Address = "İstanbul",
                LastName = "Yüksel"
            });

            manager.Add(new Student
            {
                Id = 2,
                FirstName = "ZeynepDuru",
                LastName = "Yüksel",
                Departmant = "Eng"
            });
        }
    }

    interface IPerson
    {
        int Id  { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

}

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get ; set ; }

        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }


}
