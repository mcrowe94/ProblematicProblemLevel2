using ProblematicLibrary.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblematicProblemLevel2.Tests
{
    public class CustomerTests
    {
        private static Random rng = new Random();
        private static CustomerService sut = new CustomerService(); // sut = System Under Test - The object that has the methods we are testing
        private const string FIRST_NAME = "Cruz";
        private const string LAST_NAME = "Sanchez";
        private const int AGE = 40;
        private readonly DateTime Dob = new DateTime(1985, 1, 22);

        [Fact]
        public void Should_GetCustomerFullName()
        {
            string expected = $"{FIRST_NAME} {LAST_NAME}";

            Customer actual = sut.CreateCustomer(FIRST_NAME, LAST_NAME, AGE, Dob);

            Assert.Equal(expected, actual.FullName);
        }
        
        [Fact]
        public void Should_GetCustomerAge()
        {
            int expected = AGE;

            Customer actual = sut.CreateCustomer(FIRST_NAME, LAST_NAME, AGE, Dob);

            Assert.Equal(expected, actual.Age);
        }
        
        [Fact]
        public void ShouldNot_ReturnNull()
        {
            //Random customer age and DOB
            Customer actual = sut.CreateCustomer(FIRST_NAME, LAST_NAME, GetRandomAge(), GetRandomDob()); ;

            Assert.NotNull(actual);
        }

        private int GetRandomAge()
        {
            return rng.Next(1, 101);
        }

        private DateTime GetRandomDob()
        {
            return new DateTime(rng.Next(1900, 2023), rng.Next(0, 13), rng.Next(0, 32));
        }
    }
}
