using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;

namespace Lesson_002
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello.");
            Console.Write("Could you say name, please: ");



            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name + ". Let's move on");
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = DateTime.Now.Year - age;

            Console.Write("Gender(M/F): ");
            char gender = Console.ReadLine()[0];

            Console.Write("Marital Status(D/M/S): ");
            char maritalStatus = Console.ReadLine()[0];

            Console.WriteLine("-----------------------------");

            Console.Write("Correct me ");
            if (gender == 'M')
            {
                Console.Write("man");
            }
            else
            {
                Console.Write("girl");
            }
            Console.Write(", your name is \"" + name + "\" and you were born in " + birthYear + ".");
            Console.Write(" Right(Y/N)?");

            char answer = Console.ReadLine()[0];
            if (answer == 'Y')
            {
                Console.Write("Of course I am right. Bye bye");
            }
            else
            {
                Console.Write("You ought to go to doctor. Bye");
            }



            /* 
                Hello.
                Could you say your name, please: <name>
                Nice to meet you, <name>. Let's move on
                Age: <age>
                Gender(M/F): <gender>
                Marital Status(D/M/S): <marital-status>
                ---------------------------------------
                 Correct me <If male>man<Else if female>girl, your name is "<name>" and you were born in <birth-year>. Right(Y/N)?<answer:INPUT>
                 <If answer is Y>Of course I am right. Bye bye
                 <Else if answer is N>You ought to go to doctor. Bye
            */


        }
    }
}