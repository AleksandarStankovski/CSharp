﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;  
            }
            Console.WriteLine(result);
        }
    }
}
