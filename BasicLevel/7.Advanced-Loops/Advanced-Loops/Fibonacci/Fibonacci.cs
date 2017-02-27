using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter even number:  ");
                int n = int.Parse(Console.ReadLine());

                int f0 = 1;
                int f1 = 1;
                int sum = 0;

                if (n >= 2)
                {
                    for (int i = 1; i < n; i++)
                    {
                        sum = f0 + f1;
                        f0 = f1;
                        f1 = sum;
                    }
                    Console.WriteLine(f1);
                }
                else
                {
                    Console.WriteLine(1);
                }

                
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
