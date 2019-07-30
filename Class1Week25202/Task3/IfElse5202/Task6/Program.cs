using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please think of a three letter palindrome.");

            Console.Write("Please enter the first letter: ");
            string l1 = Console.ReadLine();

            Console.Write("Please enter the second letter: ");
            string l2 = Console.ReadLine();
            if (l2 == "a" || l2 == "e" || l2 == "i" || l2 == "o" || l2 == "u")
            {
                Console.Write("Please enter the third letter: ");
                string l3 = Console.ReadLine();

                if (l1 == l3)
                    Console.WriteLine($"{l1}{l2}{l3} is a palindrome...");
                else
                    Console.WriteLine($"{l1}{l2}{l3} is not a palindrome...");

            }
            else
                Console.WriteLine("There is a problem with your word...");



        }
    }
}
