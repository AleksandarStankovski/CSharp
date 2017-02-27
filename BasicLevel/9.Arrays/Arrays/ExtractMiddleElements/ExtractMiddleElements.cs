using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = array.Length / 2 - 1;
            int end = start + 2;
            if (array.Length%2==0)
            {
                end--;
            }
            if (array.Length<=1)
            {
                start = 0;
                end = 0;
            }

            int[] mid = new int[end - start+1];
            for (int i = 0; i < mid.Length; i++)
            {
                mid[i] = array[start + i];
            }

            Console.WriteLine("{ "+string.Join(", ", mid)+" }");
        }
    }
}
