using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.Write("number 1= ");
                double maxNumber = double.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    Console.Write("number {0}= ", i+1);
                    double number = double.Parse(Console.ReadLine());
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }

                }

                Console.WriteLine(maxNumber);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
