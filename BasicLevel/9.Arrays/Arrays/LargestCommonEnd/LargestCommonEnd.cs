using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int leftCount = LargestCommonStart(firstArray, secondArray);
            int rightCount = LargestCommon(firstArray, secondArray);

            int result = Math.Max(leftCount, rightCount);

            Console.WriteLine(result);

        }

        public static int LargestCommonStart(string[] words1, string[] words2)
        {
            var lefttCount = 0;
            while (lefttCount < words1.Length && lefttCount < words2.Length)
            {
                if (words1[lefttCount] == words2[lefttCount])
                {
                    lefttCount++;
                }
                else
                {
                    break;
                }
            }
            return lefttCount;
        }

        public static int LargestCommon(string[] words1, string[] words2)
        {
            var rightCount = 0;
            while (rightCount < words1.Length && rightCount < words2.Length)
            {
                if (words1[words1.Length - rightCount - 1] == words2[words2.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            return rightCount;
        }


    }
}
