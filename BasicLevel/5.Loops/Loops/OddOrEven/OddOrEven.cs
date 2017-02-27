using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                double evenSum = 0;
                double oddSum = 0;

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("number {0} = ", i);
                    double number = double.Parse(Console.ReadLine());

                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + number;
                    }
                    else
                    {
                        oddSum = oddSum + number;
                    }

                }

                if (evenSum == oddSum)
                {
                    Console.WriteLine("Yes, sum = {0}", evenSum);
                }
                else {
                    Console.WriteLine("No, diff = {0}", Math.Abs(evenSum - oddSum));
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
