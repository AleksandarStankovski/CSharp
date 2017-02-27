using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                double leftSum = 0;
                double rightSum = 0;

                for (int i = 1; i <= n; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    leftSum = leftSum + number;

                }

                for (int i = 1; i <= n; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    rightSum = rightSum + number;

                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine("Yes, sum = {0}", leftSum);
                }
                else {
                    Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
