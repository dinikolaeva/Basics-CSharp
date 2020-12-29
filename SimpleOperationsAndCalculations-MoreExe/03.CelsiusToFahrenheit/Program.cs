using System;

namespace _003.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 1.8000) + 32;

            Console.WriteLine($"{fahrenheit:F2}");
        }
    }
}
