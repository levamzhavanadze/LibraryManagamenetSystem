using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Validators
    {

        /// <summary>
        /// Method is helper method where user is asked to enter intager value to continue process
        /// </summary>
        /// <returns>targetInt</returns>
        public int ParseUserInputToInt()
        {
            var userInput = Console.ReadLine();
            int targetInt = -99999999;

            //Until user entered value is not integer, user will be in this loop. Exception is default value of variable -99999999
            while (int.TryParse(userInput, out targetInt) == false || targetInt == -99999999)
            {
                Console.WriteLine($"Please enter valid input, you entered: <{userInput}>");
                userInput = Console.ReadLine();
            }
            return targetInt;
        }

        /// <summary>
        /// Method is helper method where user is asked to enter non empty string value to continue process
        /// </summary>
        /// <returns>targetInt</returns>
        public string ValidateUserInputOnEmptyString()
        {
            var userInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userInput) == true)
            {
                Console.WriteLine($"You did not entered any value. Please enter valid input:");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
    }
}
