using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double swimmingSeconds = distance * timeInSeconds;
            double delay = Math.Floor(distance / 15) * 12.5;

            double totalTime = (swimmingSeconds + delay);

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double neededSeconds = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
            }
        }
    }
}
