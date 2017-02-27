using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("1. square");
            Console.WriteLine("2. rectangle");
            Console.WriteLine("3. circle");
            Console.WriteLine("4. triangle");
            Console.Write("Please select figure (1, 2, 3 or 4): ");

            int figure = int.Parse(Console.ReadLine());
            double area = 0;

            if (figure == 1 || figure == 2 || figure == 3 || figure == 4)
            {
                if (figure == 1)
                {
                    Console.Write("a= ");
                    double squareA = double.Parse(Console.ReadLine());
                    area = squareA * squareA;
                }
                else if (figure == 2)
                {
                    Console.Write("a= ");
                    double rectangleA = double.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    double rectangleB = double.Parse(Console.ReadLine());
                    area = rectangleA * rectangleB;
                }
                else if (figure == 3)
                {
                    Console.Write("r= ");
                    double circleR = double.Parse(Console.ReadLine());
                    area = Math.PI * (circleR * circleR);
                }
                else if (figure == 4)
                {
                    Console.Write("a= ");
                    double triangleA = double.Parse(Console.ReadLine());
                    Console.Write("h= ");
                    double triangleH = double.Parse(Console.ReadLine());
                    area = (triangleA * triangleH) / 2;
                }

                area = Math.Round(area, 3);
                Console.WriteLine("area= {0}", area);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
