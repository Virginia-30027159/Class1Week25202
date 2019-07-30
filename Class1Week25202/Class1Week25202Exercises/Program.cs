using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Week25202Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            //displays two numbers added together so can save result
            double result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");

            //displays two numbers subtracted so result is throw away
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");

            Console.WriteLine($"{num1} * {num2} = {num1*num2}");

            Console.WriteLine($"{num1} / {num2} = {num1/num2}");

        }
    }
}
