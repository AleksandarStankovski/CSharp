using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length > 3)
            {
                int side = array.Length / 4;
                int mid = array.Length - (2 * side);
                int[] firstSideArray = new int[side];
                int[] secondSideArray = new int[side];
                int[] secondRow = new int[mid];
                int[] result = new int[mid];

                for (int i = 0; i < side; i++)
                {
                    firstSideArray[i] = array[side-1-i];
                    secondSideArray[i] = array[array.Length - 1 - i];
                }

                for (int i = 0; i < mid; i++)
                {
                    secondRow[i] = array[side + i];
                }

                int[] firstRow = firstSideArray.Concat(secondSideArray).ToArray();

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = firstRow[i]+secondRow[i];
                }

                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("Ivalid input!");
            }
        }
    }
}
