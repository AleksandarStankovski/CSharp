using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var separators = ",;:.!()\"'/\\[] ".ToArray();
            var paragraph = Console.ReadLine().Split(separators);

            var lowerWord = new List<string>();
            var mixedWord = new List<string>();
            var upperWord = new List<string>();

            foreach (var word in paragraph)
            {
                if (word != "")
                {
                    var lowerLetters = 0;
                    var upperLetters = 0;

                    foreach (var letter in word)
                    {
                        if (char.IsLower(letter))
                        {
                            lowerLetters++;
                        }
                        if (char.IsUpper(letter))
                        {
                            upperLetters++;
                        }
                    }

                    if (lowerLetters == word.Length)
                    {
                        lowerWord.Add(word);
                    }
                    else if (upperLetters == word.Length)
                    {
                        upperWord.Add(word);
                    }
                    else {
                        mixedWord.Add(word);
                    }
                }
            }

            Console.WriteLine("Lower-case {0}", string.Join(" ", lowerWord));
            Console.WriteLine("Mixed-case {0}", string.Join(" ", mixedWord));
            Console.WriteLine("Upper-case {0}", string.Join(" ", upperWord));

        }
    }
}
