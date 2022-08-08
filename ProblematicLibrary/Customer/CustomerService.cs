using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicLibrary.Customer
{
    public class CustomerService
    {
        public Customer CreateCustomer(string firstName, string lastName, int age, DateTime dob)
        {
            if (dob.Month % 2 == 0)
            {
                // Why would this even be a thing? Hint - it wouldn't
                return null;
            }

            return new Customer(firstName, lastName, age, dob);
        }

        public void PrintCustomerData(Customer c)
        {
            Console.WriteLine($"Customer Full-Name: {c.FullName} || Age: {c.Dob.ToShortDateString()} || DOB: {c.Age}");
        }
    }
}
