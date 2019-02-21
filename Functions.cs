using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonClass;
using QuestionsClass;
using PersonProgram;

namespace FunctionsClass
{
    class Functions
    {
        public static List<Person> peopleList = new List<Person>();
        public static List<string> peopleName = new List<string>();

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do:" + Environment.NewLine
               + "1) Create New Person" + Environment.NewLine
               + "2) Delete A Person" + Environment.NewLine
               + "3) List Of People" + Environment.NewLine);
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    CreatePerson();
                    break;
                case 2:
                    DeletePerson();
                    break;
                case 3:
                    ListOfPeople();
                    break;
                case 4:
                    GetAge();
                    break;
            }

        }

        public static void GetAge()
        {
            Console.Clear();
            Console.WriteLine("Please enter the first name of the person you wish to get the age for");
            var userInput = Console.ReadLine();


        }


        public static void ListOfPeople()
        {
            Console.Clear();
            int num = 1;
            int person = 0;
            int numOfPeople = peopleList.Count;
            foreach (object obj in peopleList)
            {
                var personFirstName = peopleList[person].firstName;
                var personLastName = peopleList[person].lastName;
                Console.WriteLine("{0}) " + personFirstName + " " + personLastName, num);
                num++;
                person++;
                peopleName.Add(personFirstName);
            }
            Console.WriteLine("Number Of People: {0}", numOfPeople);
            Console.ReadLine();
            MainMenu();
        }

        public static void DeletePerson()
        {
            Console.Clear();
            int personCount = peopleName.Count;
            Console.WriteLine("Please enter the number of the person you wish to delete: ");
            string userInput = Console.ReadLine();
            var isNumeric = int.TryParse(userInput, out int n);
            if (isNumeric != true)
            {
                Console.WriteLine("Jesus dude. Use a damn number!");
                DeletePerson();
            }
            if (personCount == 0)
            {
                Console.WriteLine("There are no people.");
                MainMenu();
            }
            
        }

        public static void CreatePerson()
        {
            Console.Clear();
            string fName = Questions.FirstName();
            string lName = Questions.LastName();
            string bYear = Questions.BirthYear();
            var isNumeric = int.TryParse(bYear, out int n);
            if (isNumeric != true)
            {
                Console.WriteLine("Bruh... use numbers!");
                Questions.BirthYear();
            }

            Person person = new Person(fName, lName, bYear);
            peopleList.Add(person);

            Console.WriteLine("Please hit Enter to continue.");
            Console.ReadLine();
            MainMenu();
        }
    }
}
