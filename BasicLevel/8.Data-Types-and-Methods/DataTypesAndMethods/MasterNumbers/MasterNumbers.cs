using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (SumIsDivisible(i, 7) && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        public static bool SumIsDivisible(int n, int number)
        {
            int sumOfDigits = 0;
            while (n > 0)
            {
                sumOfDigits = sumOfDigits + (n % 10);
                n = n / 10;
            }
            if (sumOfDigits % number == 0)
            {
                return true;
            }
            return true;
        }

        public static bool IsPalindrome(int n)
        {
            string digits = "" + n;
            for (int i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }
                    
            }  
            return true;
        }

    }
}
