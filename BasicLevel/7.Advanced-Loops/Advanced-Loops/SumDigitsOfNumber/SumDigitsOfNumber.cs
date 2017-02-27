using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfNumber
{
    class SumDigitsOfNumber
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            n = Math.Abs(n);

            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
