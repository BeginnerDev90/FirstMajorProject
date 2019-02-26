using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonClass;
using PersonProgram;
using FunctionsClass;

namespace QuestionsClass
{
    class Questions
    {
        public static string FirstName()
        {
            Console.WriteLine("Please enter the first name: ");
            var userInput = Console.ReadLine();
            return userInput;
        }

        public static string LastName()
        {
            Console.WriteLine("Please enter the last name: ");
            var userInput = Console.ReadLine();
            return userInput;
        }

        public static string BirthYear()
        {
            Console.WriteLine("Please enter the birth year: ");
            string userInput = Console.ReadLine();
            var isBYearNumeric = int.TryParse(userInput, out int n);
            int inputLength = userInput.Length;
            if (inputLength != 4)
            {
                Console.WriteLine("You entry is invalid. Please enter a correct year. The format is YYYY.");
                BirthYear();
            }
            else if (isBYearNumeric != true)
            {
                Console.WriteLine("Your entry is invalid. Please use a numeric birth year.");
                BirthYear();
            }
            return userInput;
        }

        public static int IDNumber()
        {
            Console.WriteLine("Please enter the person's ID number: ");
            string userInput = Console.ReadLine();
            var isIDNumeric = int.TryParse(userInput, out int n);
            int inputLength = userInput.Length;
            if (inputLength < 4 || inputLength > 10)
            {
                Console.WriteLine("You entry is invalid. Please enter between 4 and 10 digits for the ID Number.");
                IDNumber();
            } else if (isIDNumeric != true)
            {
                Console.WriteLine("Your entry is invalid. Please use a numeric ID number.");
                IDNumber();
            }
            int convertInput = Convert.ToInt32(userInput);
            return convertInput;
        }
    }
}
