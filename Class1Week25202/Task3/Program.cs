﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string fname = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lname = Console.ReadLine();

            Console.WriteLine($"Hello {fname} {lname}. ");

        }
    }
}
