using System;

namespace _02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percentExtraCosts = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                nightPrice -= nightPrice * 0.05;
            }

            double sumOfAllNights = nights * nightPrice;

            double percentExtra = budget * (percentExtraCosts * 1.0/ 100);
            double allSum = sumOfAllNights + percentExtra;

            if (budget>=allSum)
            {
                double leftSum = budget - allSum;
                Console.WriteLine($"Ivanovi will be left with {leftSum:f2} leva after vacation.");
            }
            else
            {
                double neededSum = allSum - budget;
                Console.WriteLine($"{neededSum:f2} leva needed.");
            }
        }
    }
}
