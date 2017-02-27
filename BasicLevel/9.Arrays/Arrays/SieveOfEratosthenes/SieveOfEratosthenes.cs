﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 0; i <=n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;

            for (int num = 2; num <= n; num++)
            {
                if (primes[num])
                {
                    Console.WriteLine(num);
                    int p = 2 * num;
                    while (p <= n)
                    {
                        primes[p] = false;
                        p = p + num;
                    }
                }
            }
        }

    }
}
