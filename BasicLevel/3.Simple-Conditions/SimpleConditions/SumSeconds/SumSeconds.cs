using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time 1: ");
            int firstTime = int.Parse(Console.ReadLine());
            Console.Write("Enter time 2: ");
            int secondTime = int.Parse(Console.ReadLine());
            Console.Write("Enter time 3: ");
            int thirdTime = int.Parse(Console.ReadLine());

            int time = firstTime + secondTime + thirdTime;
            int seconds = time % 60;
            int minutes = time / 60;

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
