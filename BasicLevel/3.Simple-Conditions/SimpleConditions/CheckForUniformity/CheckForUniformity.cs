using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForUniformity
{
    class CheckForUniformity
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter thir number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
       
        }
    }
}
