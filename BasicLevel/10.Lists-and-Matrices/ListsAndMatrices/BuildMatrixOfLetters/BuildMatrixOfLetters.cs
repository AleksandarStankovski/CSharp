using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildMatrixOfLetters
{
    class BuildMatrixOfLetters
    {
        static void Main(string[] args)
        {
            int numberRow = int.Parse(Console.ReadLine());
            int numberColumn = int.Parse(Console.ReadLine());

            var matrix = new char[numberRow, numberColumn];
            char letter = 'A';
            for (int row = 0; row < numberRow; row++)
            {
                for (int column = 0; column < numberColumn; column++)
                {
                    matrix[row, column] = letter;
                    letter++;
                    if (letter > 'Z') {
                        letter = 'A';
                    }
                }
            }
            for (int row = 0; row < numberRow; row++)
            {
                for (int column = 0; column < numberColumn; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
