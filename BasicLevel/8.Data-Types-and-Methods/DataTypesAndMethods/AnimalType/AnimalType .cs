using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter animal: ");
            string animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                case "dog": Console.WriteLine("dog"); break;
                case "mammal": Console.WriteLine("mammal"); break;
                case "crocodile": Console.WriteLine("crocodile"); break;
                case "tortoise": Console.WriteLine("tortoise"); break;
                case "snake": Console.WriteLine("snake"); break;
                case "reptile": Console.WriteLine("reptile"); break;
                case "others": Console.WriteLine("others"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
