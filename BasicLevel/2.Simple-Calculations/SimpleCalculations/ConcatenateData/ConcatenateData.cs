using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateData
{
    class ConcatenateData
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine(); 
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Town: ");
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2} -years old person from {3}", firstName, lastName, age, town);
        }
    }
}
