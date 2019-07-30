using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
                Console.WriteLine($"{num1} is an even number...");
            else
                Console.WriteLine($"{num1} is an odd number...");


        }
    }
}
