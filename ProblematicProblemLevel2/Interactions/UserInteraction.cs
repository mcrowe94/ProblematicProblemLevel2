using ProblematicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblemLevel2.Interaction
{
    internal static class UserInteraction
    {
        /// <summary>
        /// Wrapper for Console.ReadLine();
        /// </summary>
        /// <returns>Returns a string representation of the data typed to the console from the user</returns>
        internal static string GetUserInput()
        {
            return Console.ReadLine();
        }

        internal static int GetUserAge()
        {
            int age;

            while (int.TryParse(GetUserInput(), out age))
            {
                ConsoleLogging.PassMessage("That is not a number\nTry again...", StatusCode.Error);
            }

            return age;
        }

        internal static DateTime GetUserDob()
        {
            DateTime dob;

            while (DateTime.TryParse(GetUserInput(), out dob))
            {
                ConsoleLogging.PassMessage("That is not a valid dob please do dd/mm/yyyy \nTry again...", StatusCode.Error);
            }

            return dob;
        }

        internal static int GetUserNumber()
        {
            int num;

            while (int.TryParse(GetUserInput(), out num))
            {
                ConsoleLogging.PassMessage("That is not a valid number \nTry again...", StatusCode.Error);
            }

            return num;
        }
    }
}
