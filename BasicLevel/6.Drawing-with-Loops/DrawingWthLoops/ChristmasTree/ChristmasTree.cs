﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 100)
            {

                for (int i = 0; i <= n; i++)
                {
                    Console.Write(new string(' ', n-i));
                    Console.Write(new string('*', i));
                    Console.Write(" | ");
                    Console.Write(new string('*', i));
                    Console.Write(new string(' ', n - i));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
