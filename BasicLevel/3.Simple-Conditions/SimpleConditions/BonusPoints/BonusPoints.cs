using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            double bonusScore = 0;
            double totalScore = score;

            if (score <= 100)
            {
                bonusScore = bonusScore + 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonusScore = bonusScore + score * 0.2;
            }
            else
            {
                bonusScore = bonusScore + score * 0.1;
            }

            if (score % 2 == 0)
            {
                bonusScore = bonusScore + 1;
            }

            if (score % 10 == 5)
            {
                bonusScore = bonusScore + 2;
            }

            totalScore = score + bonusScore;

            Console.WriteLine("Bonus score: {0}", bonusScore);
            Console.WriteLine("Total score: {0}", totalScore);

        }
    }
}
