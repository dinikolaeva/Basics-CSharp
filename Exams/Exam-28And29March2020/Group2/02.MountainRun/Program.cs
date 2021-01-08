using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distace = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double secondsPerMetres = distace * time;
            double delaySeconds = Math.Floor(distace / 50) * 30;
            double allTime = secondsPerMetres + delaySeconds;

            if (allTime<record)
            {
                Console.WriteLine($"Yes! The new record is {allTime:f2} seconds.");
            }
            else
            {
                double timeNeeded = allTime - record;
                Console.WriteLine($"No! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}
