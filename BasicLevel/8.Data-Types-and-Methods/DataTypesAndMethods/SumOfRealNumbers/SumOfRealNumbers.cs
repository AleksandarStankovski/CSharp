using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfRealNumbers
{
    class SumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number {0}: ", i);
                decimal number = decimal.Parse(Console.ReadLine());
                sum = sum + number;
            }

            Console.WriteLine("sum = {0}", sum);
        }
    }
}
