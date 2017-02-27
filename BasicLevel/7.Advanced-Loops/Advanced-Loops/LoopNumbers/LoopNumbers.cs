using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopNumbers
{
    class LoopNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            Console.WriteLine(num);
            for (int i = 0; i < n; i ++)
            {
                num = num * 2;
                Console.WriteLine(num);

            }
        }
    }
}
