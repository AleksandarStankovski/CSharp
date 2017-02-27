using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFramework
{
    class SquareFramework
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write("+");
                }
                else {
                    Console.Write("|");
                }
                
                for (int col = 1; col <= n-2; col++)
                {
                    Console.Write(" -");
                }

                if (row == 1 || row == n)
                {
                    Console.WriteLine(" +");
                }
                else {
                    Console.WriteLine(" |");
                }

            }
        }
    }
}
