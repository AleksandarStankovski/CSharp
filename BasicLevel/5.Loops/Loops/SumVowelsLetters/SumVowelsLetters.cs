using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumVowelsLetters
{
    class SumVowelsLetters
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter text: ");
            string text = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sum = sum + 1;
                }
                else if (text[i] == 'e')
                {
                    sum = sum + 2;
                }
                else if (text[i] == 'i')
                {
                    sum = sum + 3;
                }
                else if (text[i] == 'o')
                {
                    sum = sum + 4;
                }
                else if (text[i] == 'u')
                {
                    sum = sum + 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
