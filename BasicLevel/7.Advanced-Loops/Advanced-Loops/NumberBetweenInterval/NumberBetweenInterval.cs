using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBetweenInterval
{
    class NumberBetweenInterval
    {
        static void Main(string[] args)
        {
            double n = 0;
            while (true)
            {
                Console.Write("Еnter a number in the range[1...100]: ");
                n = double.Parse(Console.ReadLine());

                if (n >= 1 && n <= 100)
                {
                    break;
                }

            }

            Console.WriteLine("The number i {0}", n);
        }
    }
}
