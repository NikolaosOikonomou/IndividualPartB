using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Validations
{
    internal class Validation
    {
        /// <summary>
        /// Checking the user's input for Chars instead of numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Integer(string input)
        {
            int value;
            bool temp = int.TryParse(input, out value);
            while (!temp)
            {
                Console.WriteLine("Wrong input.");
                temp = int.TryParse(Console.ReadLine(), out value);
            }
            return value;
                
           
        }
        /// <summary>
        /// Declares if the input is greater than 5 or less than 0.
        /// </summary>
        public static void Error() => Console.WriteLine("Wrong Choice");

    }
}
