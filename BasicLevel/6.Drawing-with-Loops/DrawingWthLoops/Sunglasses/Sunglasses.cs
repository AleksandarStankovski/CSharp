using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 3 && n <= 100)
            {

                for (int i = 0; i < 2 * n; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < 2 * n; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < 2 * n - 2; j++)
                    {
                        Console.Write("/");

                    }
                    Console.Write("*");
                    if (i == (n - 1) / 2 - 1)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("/");

                        }
                    }
                    else
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(" ");

                        }
                    }
                    
                    Console.Write("*");
                    for (int j = 0; j < 2 * n - 2; j++)
                    {
                        Console.Write("/");

                    }
                    Console.Write("*");
                    Console.WriteLine();
                }

                for (int i = 0; i < 2 * n; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < 2 * n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invlid input!");
            }
        }
    }
}
