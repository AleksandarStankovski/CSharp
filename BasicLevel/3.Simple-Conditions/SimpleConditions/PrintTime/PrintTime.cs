using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTime
{
    class PrintTime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hour: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            int hh = (hour + ((minutes + 15) / 60)) % 24;
            int mm = (minutes + 15) % 60;

            if (mm < 10)
            {
                Console.WriteLine(hh + ":0" + mm);
            }
            else
            {
                Console.WriteLine(hh + ":" + mm);
            }
        }
    }
}
