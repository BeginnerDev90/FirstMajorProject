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
                var personBirthYear = peopleList[person].birthYear;
                var personIDNumber = peopleList[person].idNumber;
                Console.WriteLine("{0}) Fisrt Name: " + personFirstName, num);
                Console.WriteLine("   Last Name: " + personLastName);
                Console.WriteLine("   Birth Year: " + personBirthYear);
                Console.WriteLine("   ID Number: " + personIDNumber);
                num++;
                person++;
            }
            Console.WriteLine("Number Of People: {0}", numOfPeople);
            Console.ReadLine();
            MainMenu();
        }

        public static void DeletePerson()
        {
            Console.Clear();
            int num = 1;
            int person = 0;
            List<int> idNumberList = new List<int>();
            int numOfPeople = peopleList.Count;

            foreach (object obj in peopleList)
            {
                var personFirstName = peopleList[person].firstName;
                var personLastName = peopleList[person].lastName;
                var personBirthYear = peopleList[person].birthYear;
                var personIDNumber = peopleList[person].idNumber;
                Console.WriteLine("{0}) Fisrt Name: " + personFirstName, num);
                Console.WriteLine("   Last Name: " + personLastName);
                Console.WriteLine("   Birth Year: " + personBirthYear);
                Console.WriteLine("   ID Number: " + personIDNumber);
                idNumberList.Add(personIDNumber);
                num++;
                person++;
            }
            Console.WriteLine("Please enter the ID number of the person you with to delete,");
            Console.WriteLine("or type 'q' to go back to the main menu: ");
            string userInput = Console.ReadLine();
            if (userInput == "q")
            {
                MainMenu();
            }
            var isSelectionNumeric = int.TryParse(userInput, out int n);
            int convertedInput = Convert.ToInt32(userInput);
            int inputLength = userInput.Length;
            foreach (Object personObject in peopleList)
            {
                if (idNumberList.Contains(convertedInput))
                {
                    var personToDelete = peopleList.Single(d => d.idNumber == convertedInput);
                    Console.WriteLine("Person with ID number: " + convertedInput + " will be deleted. Are you sure? Y/N");
                    string input = Console.ReadLine();
                    if (input == "y" || input == "Y")
                    {
                        peopleList.Remove(personToDelete);
                        Console.Clear();
                        DeletePerson();
                        break;
                    } else
                    {
                        DeletePerson();
                        break;
                    }
                } else if (!idNumberList.Contains(convertedInput))
                {
                    Console.WriteLine("There was no person associated with that ID number. Please try again.");
                    Console.ReadLine();
                    Console.Clear();
                    DeletePerson();
                }
            }
            
        }

        public static void CreatePerson()
        {
            Console.Clear();
            string fName = Questions.FirstName();
            string lName = Questions.LastName();
            string bYear = Questions.BirthYear();
            int idNum = Questions.IDNumber();

            Person person = new Person(fName, lName, bYear, idNum);
            peopleList.Add(person);

            Console.WriteLine("Please hit Enter to continue.");
            Console.ReadLine();
            MainMenu();
        }
    }
}
