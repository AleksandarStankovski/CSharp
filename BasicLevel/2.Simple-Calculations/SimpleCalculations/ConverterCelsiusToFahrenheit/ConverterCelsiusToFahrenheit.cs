using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterCelsiusToFahrenheit
{
    class ConverterCelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("°C = ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("{0} °C = {1} °F", celsius, fahrenheit);
        }
    }
}
