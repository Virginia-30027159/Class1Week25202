using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Week25202
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("i = " + i);
            
            /*Use the unary operator '++' to add 1 to i each time its used*/
            i++;
            Console.WriteLine("i = " + i);
            i++;
            Console.WriteLine("i = " + i);
            i++;
            Console.WriteLine("i = " + i);

            /*Ask the user to input 2 numbers and save them to double variables*/
            Console.Write("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;

            /* Use a '+' binary operator on the two variables*/
            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

            /* Use a '-' binary operator on the two variables*/
            result = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);

            /* Use a '*' binary operator on the two variables*/
            result = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);

            /* Use a '/' binary operator on the two variables*/
            result = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);

            /*In this equation the '*' has a higher precedence there for the 2 * 3 is evaluated first.*/
            double x = 10 - 2 * 3;
            Console.WriteLine("10 - 2 x 3 = " + x);
        }
    }
}
