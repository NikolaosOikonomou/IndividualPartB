using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IndividualPartB.Enums.Enum;

namespace IndividualPartB.Validations
{
    internal class Validation
    {
        /// <summary>
        /// Checking the user's input in case he'll insert characters instead of number.
        /// Using this in Primary and Secondary Menu.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Integer(string input)
        {
            int value;
            bool temp = int.TryParse(input, out value);
            while (!temp)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Wrong input.");
                Console.ResetColor();
                temp = int.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }

        public static bool LetterChecker(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Checking if the user input is inside required range.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool RangeCheck(int input,  int min, int max )
        {
            //if(!Char.IsNumber(input))
        
            if (input < min || input > max)
            {
                if(min == 1500)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tuition Fee Must be greater than 1500 euros and lower than 2500 euros");
                    Console.ResetColor();
                    return false;
                }
                else if (min ==1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Type 1 for Fulltime or 2 for Parttime");
                    Console.ResetColor();
                    return false;
                }
                else if (max == 20)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Oral mark must be between 1 - 20");
                    Console.ResetColor();
                    return false;
                }
                else if (max == 80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Total mark must be between 1 - 80");
                    Console.ResetColor();
                    return false;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Number Must be between 100 and 123");
                    Console.ResetColor();
                    return false;
                }

            }
            else
                return true;
        }

        /// <summary>
        /// Checking the user input not to cantain a number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ProperNameInput(string input)
        {
            if (input.Any(x => char.IsDigit(x) || char.IsSymbol(x)) || string.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Must Contain only letters");
                Console.ResetColor();
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Checking Trainer's Subject input 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ProperCourseInput(string input)
        {
            if (!(input == "C#" || input == "Java" || input == "Python" || input == "Fortran"))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Wrong Input");
                Console.ResetColor();
                return false;
            }
            else
                return true;
         
        }


        /// <summary>
        /// Using this method in Primary and Secondary Menu in Switch case default value.
        /// </summary>
        public static void Error() => Console.WriteLine("Wrong Choice");

    }
}
