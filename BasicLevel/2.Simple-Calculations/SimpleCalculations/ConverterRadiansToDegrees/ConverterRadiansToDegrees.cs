using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterRadiansToDegrees
{
    class ConverterRadiansToDegrees
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            double rad = double.Parse(Console.ReadLine());

            double deg = Math.Round(rad * 180 / Math.PI);

            Console.WriteLine("{0} radians = {1} degrees", rad, deg);
        }
    }
}
