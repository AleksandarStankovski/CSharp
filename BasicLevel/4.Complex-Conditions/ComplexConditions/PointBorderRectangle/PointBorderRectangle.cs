using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBorderRectangle
{
    class PointBorderRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("x1= ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1= ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2= ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2= ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());

            double leftSide = Math.Min(x1, x2);
            double rightSide = Math.Max(x1, x2);

            double lowerSide = Math.Min(y1, y2);
            double upperSide = Math.Max(y1, y2);

            if (((x == leftSide || x == rightSide) && (y >= lowerSide && y <= upperSide)) || ((x >= leftSide && x <= rightSide) && (y == lowerSide || y == upperSide)))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
