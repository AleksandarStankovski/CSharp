using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();

            for (int start = 0; start < numbers.Count; start++)
            {
                int end;
                for (end = start + 1; end < numbers.Count; end++)
                {
                    if (numbers[start] != numbers[end])
                    {
                        break;
                    }
                }
                var count = end - start;
                start = end - 1;
                Console.WriteLine("{0} -> {1}", numbers[start], count);
                
            }
        }
    }
}
