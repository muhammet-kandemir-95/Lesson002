using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Lesson_002
{
    class Program_MERT
    {
        public static void Main_MERT(string[] args)
        {
            Console.Write("Could I get your name, please: ");
            string name = Console.ReadLine();

            Console.WriteLine("Thanks " + name + ". Also, I need to get other informations.");
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = DateTime.Now.Year - age;
            Console.Write("Are you single(Y/N): "); //maritalsstatu
            char isSingle = Console.ReadLine()[0];
            if (isSingle == 'Y')
            {
                Console.WriteLine("Holy crap, I thought you are married.");

            }
            else
            {
                Console.WriteLine("Holy marriage, I thought you are single.");

            }
            Console.Write("Gender(M/F): ");
            char gender = Console.ReadLine()[0];
            if (gender == 'F' && isSingle == 'Y')
            {
                Console.WriteLine("I do not know how it is possible.");
            }
            else if (gender == 'M' && isSingle == 'N')
            {
                Console.WriteLine("I do not know how it is possible.");

            }
            else
            {
                Console.WriteLine("Good, good.");
            }
            Console.Write("Anyway, nice to meet you " + name + ". " + birthYear + " is not too far from us. Have a good day ");

            if (gender == 'M')
            {
                Console.Write("sir.");
            }
            else
            {
                Console.Write("mam.");
            }







            /* Could I get your name, please: <name:INPUT> */
            /* 
                Thanks <name>. Also, I need to get other informations.
                Age: <age>
                Are you single(Y/N): <marital-status>
                <If single> Holy crap, I thought you are married.
                <If married> Holy marriage, I thought you are single.
                Gender(M/F): <gender>
                <If female and single or male and married >I do not know how it is possible.
                Anyway, nice to meet you <name>. <birth-year> is not too far from us. Have a good day <If male>sir<Else if female>mam.
                 */


        }
    }
}