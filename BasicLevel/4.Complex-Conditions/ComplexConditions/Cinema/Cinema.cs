using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            Console.Write("Enter type projection: ");
            string typeProjection = Console.ReadLine().ToLower();

            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter columns: ");
            int columns = int.Parse(Console.ReadLine());

            double seats = rows * columns;
            double income = -1;

            if (typeProjection == "premiere")
            {
                income = seats * 12.00;
            }
            else if (typeProjection == "normal")
            {
                income = seats * 7.50;
            }
            else if (typeProjection == "discount")
            {
                income = seats * 5.00;
            }

            if (income >= 0)
            {
                Console.WriteLine("{0:f2} leva", income);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
