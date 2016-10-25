using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert given number grades into letter grades
            Console.WriteLine("Welcome to the Letter Grade Converter!");


            string prompt;
            do
            {
                Console.WriteLine("Please enter a numerical grader: ");

                string inputGrade = Console.ReadLine();

                int inputInt = Convert.ToInt32(inputGrade);

                if (inputInt >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (inputInt >= 80 && inputInt <= 89)
                {
                    Console.WriteLine("Letter Grade: B");
                }

                else if (inputInt >= 70 && inputInt <= 79)
                {
                    Console.WriteLine("Letter Grade: C");
                }

                else if (inputInt >= 60 && inputInt <= 69)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (inputInt <= 59)
                {
                    Console.WriteLine("Letter Grade: F");
                }

                Console.Write("Do you want to continue?(y/n): ");

                prompt = Console.ReadLine();
            }
            while (prompt == "y" || prompt == "Y") ;

        }


    }
}

