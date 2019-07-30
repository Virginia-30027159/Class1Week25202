using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse5202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("the two numbers you entered are equal. ");
            else if (num1 > num2)
                Console.WriteLine($"{num1} is larger. ");
            else if (num1 < num2)
                Console.WriteLine($"{num2} is larger. ");
        }
    }
}
