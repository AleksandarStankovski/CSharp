using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangle
{
    class AreaTriangle
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;
            double areaTriangle = Math.Round(area, 2);

            Console.WriteLine("Triangle area = {0}", areaTriangle);

        }
    }
}
