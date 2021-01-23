using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer
            {
                Id = 1,
                CustomerNo = "12345",
                Name = "Furkan",
                LastName = "Ozgun",
                TcNo = "11212121"
            };

            CorporateCustomer customer2 = new CorporateCustomer
            {
                Id = 1,
                CompanyName = "KK",
                CustomerNo = "125487",
                TaxNo = "16"
            };


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
