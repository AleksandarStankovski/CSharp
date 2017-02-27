using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSum
{
    class NumberSum
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("number {0}= ", i);
                    double number = double.Parse(Console.ReadLine());
                    sum = sum + number;
                }

                Console.WriteLine("sum= {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
