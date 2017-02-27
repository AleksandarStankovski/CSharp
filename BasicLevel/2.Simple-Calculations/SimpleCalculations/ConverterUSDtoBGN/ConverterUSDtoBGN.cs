using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterUSDtoBGN
{
    class ConverterUSDtoBGN
    {
        static void Main(string[] args)
        {
            Console.Write("USD = ");
            double USD = double.Parse(Console.ReadLine());

            double BGN = Math.Round(USD * 1.79549, 2);

            Console.WriteLine("{0} USD = {1} BGN", USD, BGN);
        }
    }
}
