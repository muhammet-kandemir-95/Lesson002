using System;
using System.Diagnostics;

namespace Lesson_002
{
    class Program_HAMZA
    {
        public static void Main_HAMZA(string[] args)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = DateTime.Now.Year - age;

            Console.Write("gender(M/F): ");
            char gender = Console.ReadLine()[0];

            Console.Write("marital status(S/M/D):");
            char maritalStatus = Console.ReadLine()[0];

            Console.WriteLine("--------------------------------------------------");

            Console.Write("Hi " + name + ", welcome. As I understood, you are " + age + " years old. So, you was born in " + birthYear + ". And you are a");

            if (age>=0 && age<18)
            {
                Console.Write(" young");
            
            }
            else if (age>=18 && age<45)
            {
                Console.Write("n adult");
    
            }
            else 
            {
                Console.Write("n old");
            }

            if (gender == 'M')
            {
                Console.Write(" male");
            }
            else if (gender == 'F')
            {
                Console.Write(" female");
            }

            Console.Write(" person.");
        
            if (maritalStatus == 'S')
            {
                Console.Write(" You are single but I hope you will get married soon.");
            }
            else if (maritalStatus == 'M')
            {
                Console.Write(" You are married and I wish best for both of you.");
            }
            else
            {
                Console.Write(" You have divorced but I wish that you will find better one.");
            }
            
            /*
                Hi <name>, welcome. As I understood, you are <age> years old. So, you was born in <birth-year>. And you are a <young/adult/old> <gender> person. <If single> You are single but I hope you will get married soon. <If married> You are married and I wish best for both of you. <If divorced> You have divorced but I wish that you will find a better one.
            */
        }
    }
}