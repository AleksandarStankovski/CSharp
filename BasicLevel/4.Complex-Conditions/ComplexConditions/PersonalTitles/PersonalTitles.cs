using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            Console.Write("age: ");
            double age = double.Parse(Console.ReadLine());

            Console.Write("gender (m or f): ");
            string gender = Console.ReadLine();

            if (gender == "m" || gender == "f")
            {
                if (age >= 16)
                {
                    if (gender == "m")
                    {
                        Console.WriteLine("Mr.");
                    }
                    else if (gender == "f")
                    {
                        Console.WriteLine("Ms.");
                    }
                }
                else
                {
                    if (gender == "m")
                    {
                        Console.WriteLine("Master");
                    }
                    else if (gender == "f")
                    {
                        Console.WriteLine("Miss");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
