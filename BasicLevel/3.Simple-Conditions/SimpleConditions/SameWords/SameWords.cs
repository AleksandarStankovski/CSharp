using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameWords
{
    class SameWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word: ");
            string firstWord = Console.ReadLine();
            Console.Write("Enter second word: ");
            string secondWord = Console.ReadLine();

            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();

            if (firstWord == secondWord)
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
