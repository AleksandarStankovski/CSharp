using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            for (int i = 1; i <= n-2; i++)
            {
                PrintBody(n);
            }
            PrintHeader(n);
        }

        public static void PrintHeader(int n)
        {
            for (int i = 1; i <= n*2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public static void PrintBody(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
