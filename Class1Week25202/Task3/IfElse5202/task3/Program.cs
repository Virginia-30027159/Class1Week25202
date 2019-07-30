using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter final mark out of 100: ");
            float num1 = float.Parse(Console.ReadLine());

            if (num1 >= 90 && num1 <= 100)
                Console.WriteLine("Your grade is an A+. ");
            else if (num1 >= 80 && num1 <= 89)
                Console.WriteLine("Your grade is an A. ");
            else if (num1 >= 70 && num1 <= 79)
                Console.WriteLine("Your grade is an B+. ");
            else if (num1 >= 60 && num1 <= 69)
                Console.WriteLine("Your grade is an B. ");
            else if (num1 >= 50 && num1 <= 59)
                Console.WriteLine("Your grade is an C. ");
            else if (num1 >= 40 && num1 <= 49)
                Console.WriteLine("Your grade is an D. ");
            else if (num1 >= 0 && num1 <= 39)
                Console.WriteLine("Your grade is an F. ");

            else
                Console.WriteLine("There was a problem with the mark you entered. ");

        }
    }
}
