using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenNumber
{
    class OddOrEvenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0) {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
