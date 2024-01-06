using System;

namespace Lesson_002
{
    class Program_BAK
    {
        public static void Main2(string[] args)
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = DateTime.Now.Year - age;

            Console.Write("What is your height in meter: "); // 1.75
            float height = Convert.ToSingle(Console.ReadLine());
            if (height > 9 && height < 100)
            {
                height = height / 10;
            }
            else if (height >= 100)
            {
                height = height / 100;
            }

            Console.Write("What is your gender(M/F): ");
            char gender = Console.ReadLine()[0];

            Console.Write("What is your marital status(S/M/D): ");
            char maritalStatus = Console.ReadLine()[0];

            /*
                Your Informations:
                    > Fullname: "Muhammet Kandemir"
                    > Gender: Male/Female/Unknown
                    > Birth Year: 1995
                    > Height: 175 cm
                    > Marital Status: Single/Married/Divorced
            */

            Console.WriteLine("Your Informations:");
            Console.WriteLine("    > Fullname: \"" + firstName + " " + lastName + "\"");
            if (gender == 'M')
            {
                Console.WriteLine("    > Gender: Male");
            } 
            else if (gender == 'F')
            {
                Console.WriteLine("    > Gender: Female");
            }
            else 
            {
                Console.WriteLine("    > Gender: Unknown");
            }
            Console.WriteLine("    > Birth Year: " + birthYear);
            Console.WriteLine("    > Height: " + (height * 100) + " cm");
            if (maritalStatus == 'S')
            {
                Console.WriteLine("    > Marital Status: Single");
            } 
            else if (maritalStatus == 'M')
            {
                Console.WriteLine("    > Marital Status: Married");
            }
            else if (maritalStatus == 'D')
            {
                Console.WriteLine("    > Marital Status: Divorced");
            }
            else 
            {
                Console.WriteLine("    > Marital Status: Unknown");
            }
        }
    }
}