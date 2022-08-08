using System;
using ProblematicLibrary;
using ProblematicLibrary.Calculator;
using ProblematicLibrary.Customer;
using static ProblematicProblemLevel2.Interaction.ConsoleLogging;
using static ProblematicProblemLevel2.Interaction.UserInteraction;

namespace ProblematicProblemLevel2
{
    class Program
    {
        private static CustomerService customerService = new CustomerService();
        private static Calculator calculator = new Calculator();

        static void Main(string[] args)
        {
            PassMessage("Welcome to your problematic problem");
            NewLine();

            PassMessage("We will start with creating a customer!");
            NewLine();

            PassMessage("Please enter their first name...");
            string firstName = GetUserInput();
            NewLine();
            
            PassMessage("Please enter their last name...");
            string lastName = GetUserInput();
            NewLine();

            PassMessage("Please enter their age...");
            int age = GetUserAge();
            NewLine();

            PassMessage("Please enter their date of birth...");
            DateTime dob = GetUserDob();
            NewLine();

            Customer c = customerService.CreateCustomer(firstName, lastName, age, dob);

            customerService.PrintCustomerData(c);
            NewLine();

            PassMessage("Now we will do some calculations!!");
            NewLine();

            PassMessage("Give me a number");
            int x = GetUserNumber();
            NewLine();

            PassMessage("Give me another number");
            int y = GetUserNumber();
            NewLine();

            PassMessage("I will now do the 4 standard math calculations on those 2 numbers");

            PassMessage($"Addition: {x} + {y} = {calculator.Add(x, y)}");
            PassMessage($"Subtraction: {x} + {y} = {calculator.Multiply(x, y)}");
            PassMessage($"Multiplication: {x} + {y} = {calculator.Divide(x, y)}");
            PassMessage($"Division: {x} + {y} = {calculator.Subtract(x, y)}");
            NewLine();

            PassMessage("Isn't math fun!", StatusCode.Success);            
            
            SithLord.ExecuteOrder66();
        }
    }
}
