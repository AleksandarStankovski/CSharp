using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowNumbers
{
    class RowNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            
            for (int i = 1; i <= n ; i++)
            {
                if (num <= n)
                {
                    Console.WriteLine(num);
                    num = num * 2 + 1;
                    
                }
                

            }
        }
    }
}
