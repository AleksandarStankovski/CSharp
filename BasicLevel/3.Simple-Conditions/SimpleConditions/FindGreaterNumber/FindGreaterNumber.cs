using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGreaterNumber
{
    class FindGreaterNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int greaterNumber = firstNumber;

            if (firstNumber >= secondNumber)
            {
                greaterNumber = firstNumber;
            }
            else
            {
                greaterNumber = secondNumber;
            }

            Console.WriteLine("Greater numner: {0}", greaterNumber);
        }
    }
}
