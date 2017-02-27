using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 2 && n <= 100)
            {
                int star = 1;
                if (n % 2 == 0)
                {
                    star = 2;
                }

                for (int row = 0; row < (n + 1) / 2; row++)
                {
                    for (int col = 0; col < (n - star) / 2; col++)
                    {
                        Console.Write("/");
                    }
                    for (int col = 0; col < star; col++)
                    {
                        Console.Write("*");
                    }
                    for (int col = 0; col < (n - star) / 2; col++)
                    {
                        Console.Write("/");
                    }
                    star = star+2;
                    Console.WriteLine();
                }
                for (int row = 0; row < n / 2; row++)
                {
                    Console.Write("|");
                    for (int col = 0; col < n-2; col++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }

                
            }
            else
            {
                Console.WriteLine("Invlid input!");
            }
        }
    }
}
