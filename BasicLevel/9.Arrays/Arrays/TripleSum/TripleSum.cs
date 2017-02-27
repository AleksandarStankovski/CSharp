using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];
                    if (nums.Contains(sum))
                    {
                        count++;
                        Console.WriteLine("{0} + {1} == {2}", nums[i], nums[j], sum);
                    }
                    
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
