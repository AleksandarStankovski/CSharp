using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            Console.Write("Enter producut (coffee, water, beer, sweets or peanuts): ");
            string product = Console.ReadLine().ToLower(); ;

            Console.Write("Enter town (Sofia, Plovdiv or Varna): ");
            string town = Console.ReadLine().ToLower();

            Console.Write("Enter quantity: ");
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            bool checkProduct = product == "coffee" || product == "water" || product == "beer" || product == "sweets" || product == "peanuts";
            bool ckechTwon = town == "sofia" || town == "plovdiv" || town == "varna";

            if (checkProduct && ckechTwon)
            {
                if (town == "sofia")
                {
                    if (product == "coffee")
                    {
                        price = quantity * 0.50;
                    }
                    else if (product == "water")
                    {
                        price = quantity * 0.80;
                    }
                    else if (product == "beer")
                    {
                        price = quantity * 1.20;
                    }
                    else if (product == "sweets")
                    {
                        price = quantity * 1.45;
                    }
                    else if (product == "peanuts")
                    {
                        price = quantity * 1.60;
                    }
                }
                else if (town == "plovdiv")
                {
                    if (product == "coffee")
                    {
                        price = quantity * 0.40;
                    }
                    else if (product == "water")
                    {
                        price = quantity * 0.70;
                    }
                    else if (product == "beer")
                    {
                        price = quantity * 1.15;
                    }
                    else if (product == "sweets")
                    {
                        price = quantity * 1.30;
                    }
                    if (product == "peanuts")
                    {
                        price = quantity * 1.50;
                    }
                }
                else if (town == "varna")
                {
                    if (product == "coffee")
                    {
                        price = quantity * 0.45;
                    }
                    else if (product == "water")
                    {
                        price = quantity * 0.70;
                    }
                    else if (product == "beer")
                    {
                        price = quantity * 1.10;
                    }
                    else if (product == "sweets")
                    {
                        price = quantity * 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        price = quantity * 1.55;
                    }
                }
                Console.WriteLine(price);
            }
            else {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
