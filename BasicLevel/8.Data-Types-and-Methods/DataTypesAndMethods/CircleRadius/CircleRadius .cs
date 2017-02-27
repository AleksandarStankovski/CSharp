using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("radius = ");
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * (r * r);
            Console.WriteLine("area = {0:f12}", area);
        }
    }
}
