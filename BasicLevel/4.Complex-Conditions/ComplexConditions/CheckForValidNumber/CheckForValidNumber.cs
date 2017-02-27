using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForValidNumber
{
    class CheckForValidNumber
    {
        static void Main(string[] args)
        {
            Console.Write("number=");
            int number = int.Parse(Console.ReadLine());

            if (!((number >= 100 && number <= 200) || number == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
