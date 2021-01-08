using System;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfEggs = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            for (int collourEggs = 0; collourEggs < countOfEggs; collourEggs++)
            {

                string collour = Console.ReadLine();

                if (collour == "red")
                {
                    red++;
                }
                else if (collour == "orange")
                {
                    orange++;
                }
                else if (collour == "blue")
                {
                    blue++;
                }
                else if (collour == "green")
                {
                    green++;
                }

            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");

            if (red > orange && red > blue && red > green)
            {
                Console.WriteLine($"Max eggs: {red} -> red");
            }
            else if (orange > red && orange > blue && orange > green)
            {
                Console.WriteLine($"Max eggs: {orange} -> orange");
            }
            else if (blue > red && blue > orange && blue > green)
            {
                Console.WriteLine($"Max eggs: {blue} -> blue");
            }
            else if (green > red && green > orange && green > blue)
            {
                Console.WriteLine($"Max eggs: {green} -> green");
            }
        }
    }
}
