using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumbers
{
    class PyramidOfNumbers
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                int number = 1;

                for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        if (col > 1)
                        {
                            Console.Write(" ");
                        }
                        if (number > n)
                        {
                            break;
                        }
                        Console.Write(number);
                        number++;
                    }
                    Console.WriteLine();
                    if (number > n)
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
