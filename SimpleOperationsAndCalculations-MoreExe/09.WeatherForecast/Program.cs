using System;

namespace _009.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string warm = Console.ReadLine();

            if (warm == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (warm != "sunny")
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
