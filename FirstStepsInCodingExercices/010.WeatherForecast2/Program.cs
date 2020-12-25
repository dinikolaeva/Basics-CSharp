using System;

namespace _010.WeatherForecast2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            if (degrees <5)
            {
                Console.WriteLine("unknown");
            }
            else if (degrees <=11.90)
            {
                Console.WriteLine("Cold");
            }
            else if (degrees <=14.90)
            {
                Console.WriteLine("Cool");
            }
            else if (degrees <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degrees <= 25.90)
            {
                Console.WriteLine("Warm");
            }
            else if (degrees <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degrees > 35.00)
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
