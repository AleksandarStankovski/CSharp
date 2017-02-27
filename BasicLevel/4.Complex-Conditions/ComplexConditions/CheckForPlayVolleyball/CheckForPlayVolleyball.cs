using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPlayVolleyball
{
    class CheckForPlayVolleyball
    {
        static void Main(string[] args)
        {
            Console.Write("Leap or normal year: ");
            string year = Console.ReadLine().ToLower();

            Console.Write("Number of holidays: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Number of weekends: ");
            int h = int.Parse(Console.ReadLine());

            double weekendsSofia = 48 - h;
            double numberGamesWeekendsSofia = weekendsSofia * (3.0 / 4);
            double numberGamesHometown = h;
            double numberGamesHolidays = p * (2.0 / 3);

            double totalGames = numberGamesWeekendsSofia + numberGamesHometown + numberGamesHolidays;

            if (year == "leap")
            {
                totalGames = totalGames + (totalGames * 0.15);
            }

            Console.WriteLine(Math.Truncate(totalGames));
        }
    }
}
