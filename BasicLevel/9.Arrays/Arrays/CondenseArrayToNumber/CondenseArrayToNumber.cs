using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (array.Length > 1)
            {
                int[] newArray = new int[array.Length-1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    newArray[i] = array[i] + array[i + 1];
                }
                array = newArray;
            }
            Console.WriteLine(array[0]);
        }
    }
}
