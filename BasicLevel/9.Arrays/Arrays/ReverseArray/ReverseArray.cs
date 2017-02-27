using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int oldElement = nums[0];

            for (int i = 0; i < nums.Length/2; i++)
            {
                oldElement = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = oldElement;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
