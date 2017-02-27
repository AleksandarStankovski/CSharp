using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessPassword
{
    class GuessPassword
    {
        static void Main(string[] args)
        {
            Console.Write("Enter new password: ");
            string newPassword = Console.ReadLine();
            string oldPassword = "s3cr3t!P@ssw0rd";

            if (newPassword == oldPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
