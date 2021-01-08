using System;

namespace _2.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            const double easterBread = 4;
            const double egg = 0.45;

            int countOfGuests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double countOfEasterBreads = countOfGuests/3.0;
            countOfEasterBreads = Math.Ceiling(countOfEasterBreads);

            int counOfEggs = countOfGuests * 2;

            double easterBreadsPrice = countOfEasterBreads * easterBread;
            double eggsPrice = counOfEggs * egg;

            double totalSum = easterBreadsPrice + eggsPrice;

            if (budget >= totalSum)
            {
                double leftMoney = budget - totalSum;
                Console.WriteLine($"Lyubo bought {countOfEasterBreads} Easter bread and {counOfEggs} eggs.");

                Console.WriteLine($"He has {leftMoney:f2} lv. left.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneyNeeded:F2} lv. more.");
            }
        }
    }
}
