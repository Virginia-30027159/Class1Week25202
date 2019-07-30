using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mynum = 8;

            Console.Write("Try and guess my number from 1 to 10: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < mynum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry your guess was to low. ");
            }
            else if (guess > mynum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry your guess was to high. ");
            }
            
            else Console.WriteLine("You got it. ");
            
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}
