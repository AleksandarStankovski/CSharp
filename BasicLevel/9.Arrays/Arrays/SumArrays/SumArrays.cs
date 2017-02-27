using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array 1: ");
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Enter array 2: ");
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLength = Math.Max(firstArray.Length, secondArray.Length);
            int[] sum = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                sum[i] = (firstArray[i % firstArray.Length]) + (secondArray[i % secondArray.Length]);
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
