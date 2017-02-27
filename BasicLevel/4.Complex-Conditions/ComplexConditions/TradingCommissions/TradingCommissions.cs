using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCommissions
{
    class TradingCommissions
    {
        static void Main(string[] args)
        {
            Console.Write("Enter town (Sofia, Varna, or Plovdiv): ");
            string town = Console.ReadLine().ToLower(); ;

            Console.Write("Enter volume of sales: ");
            double salesVolume = double.Parse(Console.ReadLine());

            double commision = -1;

            if (town == "sofia")
            {
                if (salesVolume >=0 && salesVolume <= 500)
                {
                    commision = salesVolume * 0.05;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commision = salesVolume * 0.07;
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    commision = salesVolume * 0.08;
                }
                else if (salesVolume > 10000)
                {
                    commision = salesVolume * 0.12;
                }
            }
            else if (town == "varna")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commision = salesVolume * 0.045;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commision = salesVolume * 0.075;
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    commision = salesVolume * 0.10;
                }
                else if (salesVolume > 10000)
                {
                    commision = salesVolume * 0.13;
                }
            }
            else if (town == "plovdiv")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commision = salesVolume * 0.055;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commision = salesVolume * 0.08;
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    commision = salesVolume * 0.12;
                }
                else if (salesVolume > 10000)
                {
                    commision = salesVolume * 0.145;
                }
            }

            if (commision >= 0)
            {
                Console.WriteLine("{0:f2}", commision);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
