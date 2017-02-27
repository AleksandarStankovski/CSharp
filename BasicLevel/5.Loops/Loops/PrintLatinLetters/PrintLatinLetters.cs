using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLatinLetters
{
    class PrintLatinLetters
    {
        static void Main(string[] args)
        {
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write("{0} ", letter);
            }
            Console.WriteLine();
        }
    }
}
