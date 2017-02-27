using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.Write("number 1= ");
                double minNumber = double.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    Console.Write("number {0}= ", i + 1);
                    double number = double.Parse(Console.ReadLine());
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }

                }

                Console.WriteLine(minNumber);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
