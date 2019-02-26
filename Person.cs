using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonProgram;
using QuestionsClass;
using FunctionsClass;

namespace PersonClass
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public string birthYear;
        public int idNumber;

        public Person()
        {

        }


        public Person(string fName)
        {
            this.firstName = fName;
        }

        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }

        public Person(string fName, string lName, string bYear)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthYear = bYear;
        }

        public Person(string fName, string lName, string bYear, int idNum)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthYear = bYear;
            this.idNumber = idNum;
        }

        public static int CheckID(int idNum)
        {
            
            return idNum;
        }

    }
}
