using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class SpecialNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;
            for (int i = 1; i <= n; i++)
            {
                sum = SumOfDigits(i);
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }

        private static int SumOfDigits(int digits)
        {
            int sum = 0;
            while (digits > 0)
            {
                sum = sum + (digits % 10);
                digits = digits / 10;
            }
            return sum;
        }
    }
}
