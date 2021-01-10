using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {

            const double fuel = 2.10;
            const double gid = 100;

            double budget = double.Parse(Console.ReadLine());
            double fuelNeeded = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double fuelPrice = fuel * fuelNeeded;
            double priceWithGid = fuelPrice + gid;

            double totalSum = 0;

            if (day == "Saturday")
            {
                totalSum = priceWithGid - (priceWithGid * 0.10);
            }
            else
            {
                totalSum = priceWithGid - (priceWithGid * 0.20);
            }

            if (budget > totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
    }
}
