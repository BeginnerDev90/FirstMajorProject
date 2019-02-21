using System;
using System.Collections.Generic;
using QuestionsClass;
using PersonClass;
using FunctionsClass;

/*namespace Node
{
    public class PublicNode
    {
        public static string NodeText(string str1, string str2)
        {
            string complete = str1 + " " + str2 + "!";

            return complete;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string helloFirst;
            string helloSecond;
            string complete;

            Console.Write("Please Enter 'Hello': ");
            helloFirst = Console.ReadLine();
            Console.Write("Please Enter 'World': ");
            helloSecond = Console.ReadLine();

            complete = PublicNode.NodeText(helloFirst, helloSecond);

            Console.WriteLine(complete);

            Console.ReadLine();
        }
    }
}
*/



namespace PersonProgram { 

    public class PersonProgram
    {
        static void Main(string[] args)
        {
            Functions.MainMenu();
        }

    }
}