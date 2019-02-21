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
            var userInput = Console.ReadLine();
            return userInput;
        }
    }
}
