using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a 4 digit pin number: ");
            int pin = int.Parse(Console.ReadLine());

            if (pin >= 1000 && pin <= 9999)
            {
                Console.Write("Please re-enter your pin number: ");
                int pin1 = int.Parse(Console.ReadLine());

                if (pin == pin1)
                    Console.WriteLine("Pin Accepted. ");
                else
                    Console.WriteLine("Your pins did not match. ");
            }
            else
                Console.WriteLine("your pin is not acceptable.");

            Console.ReadLine();
            Console.Clear();

        }
    }
}
