using System;

namespace _03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {

            string country = Console.ReadLine();
            string device = Console.ReadLine();

            double difficulty = 0;
            double performing = 0;

            if (country == "Russia")
            {
                switch (device)
                {
                    case "ribbon":
                        difficulty = 9.100;
                        performing = 9.400;
                        break;
                    case "hoop":
                        difficulty = 9.300;
                        performing = 9.800;
                        break;
                    case "rope":
                        difficulty = 9.600;
                        performing = 9.000;
                        break;
                }

            }
            else if (country == "Bulgaria")
            {
                switch (device)
                {
                    case "ribbon":
                        difficulty = 9.600;
                        performing = 9.400;
                        break;
                    case "hoop":
                        difficulty = 9.550;
                        performing = 9.750;
                        break;
                    case "rope":
                        difficulty = 9.500;
                        performing = 9.400;
                        break;
                }
            }
            else
            {
                switch (device)
                {
                    case "ribbon":
                        difficulty = 9.200;
                        performing = 9.500;
                        break;
                    case "hoop":
                        difficulty = 9.450;
                        performing = 9.350;
                        break;
                    case "rope":
                        difficulty = 9.700;
                        performing = 9.150;
                        break;
                }
            }

            double totalPoints = difficulty + performing;
            double pointsLeft = 20 - totalPoints;
            double percentFromAllPoints = (pointsLeft / 20) * 100;

            Console.WriteLine($"The team of {country} get {totalPoints:f3} on {device}.");
            Console.WriteLine($"{percentFromAllPoints:f2}%");
        }
    }
}
