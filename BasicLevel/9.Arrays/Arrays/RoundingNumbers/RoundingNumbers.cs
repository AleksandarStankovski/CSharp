using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    Console.WriteLine("{0} => {1}", nums[i], (int)(nums[i] + 0.5));
                }
                else
                {
                    Console.WriteLine("{0} => {1}", nums[i], (int)(nums[i] - 0.5));
                }
            }
        }
    }
}
