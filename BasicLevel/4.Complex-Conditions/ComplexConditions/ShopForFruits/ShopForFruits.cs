using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopForFruits
{
    class ShopForFruits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter producut (banana, apple, orange, grapefruit, kiwi, pineapple or grapes): ");
            string product = Console.ReadLine().ToLower(); ;

            Console.Write("Enter day of the week: ");
            string day = Console.ReadLine().ToLower();

            Console.Write("Enter quantity: ");
            double quantity = double.Parse(Console.ReadLine());

            double price = -1;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (product == "banana")
                {
                    price = quantity * 2.50;
                }
                else if (product == "apple")
                {
                    price = quantity * 1.20;
                }
                else if (product == "orange")
                {
                    price = quantity * 0.85;
                }
                else if (product == "grapefruit")
                {
                    price = quantity * 1.45;
                }
                else if (product == "kiwi")
                {
                    price = quantity * 2.70;
                }
                else if (product == "pineapple")
                {
                    price = quantity * 5.50;
                }
                else if (product == "grapes")
                {
                    price = quantity * 3.85;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (product == "banana")
                {
                    price = quantity * 2.70;
                }
                else if (product == "apple")
                {
                    price = quantity * 1.25;
                }
                else if (product == "orange")
                {
                    price = quantity * 0.90;
                }
                else if (product == "grapefruit")
                {
                    price = quantity * 1.60;
                }
                else if (product == "kiwi")
                {
                    price = quantity * 3.00;
                }
                else if (product == "pineapple")
                {
                    price = quantity * 5.60;
                }
                else if (product == "grapes")
                {
                    price = quantity * 4.20;
                }
            }

            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
