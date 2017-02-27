using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class RotateMatrix
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());
            int numberColumns = int.Parse(Console.ReadLine());

            var matrix = new string[numberRows, numberColumns];

            for (int row = 0; row < numberRows; row++)
            {
                var line = Console.ReadLine().Split(' ');
                for (int column = 0; column < numberColumns; column++)
                {
                    matrix[row, column] = line[column];
                }
            }

            var resultRows = numberColumns;
            var resultColumns = numberRows;
            var result = new string[resultRows, resultColumns];

            for (int row = 0; row < numberRows; row++)
            {
                for (int column = 0; column < numberColumns; column++)
                {
                    result[column, resultColumns-1-row] = matrix[row, column];
                }
            }

            for (int row = 0; row < resultRows; row++)
            {
                for (int column = 0; column < resultColumns; column++)
                {
                    Console.Write(result[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
