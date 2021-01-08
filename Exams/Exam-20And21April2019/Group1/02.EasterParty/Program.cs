using System;
using System.Security.Claims;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGuests = int.Parse(Console.ReadLine());
            double coverForAPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (countOfGuests >= 10 && countOfGuests <= 15)
            {
                coverForAPerson -= coverForAPerson * 0.15;
            }
            else if (countOfGuests > 15 && countOfGuests <= 20)
            {
                coverForAPerson -= coverForAPerson * 0.20;
            }
            else if (countOfGuests > 20)
            {
                coverForAPerson -= coverForAPerson * 0.25;
            }

            double cakePrice = budget * 0.10;
            double totalSum = coverForAPerson * countOfGuests + cakePrice;

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"No party! {moneyNeeded:f2} leva needed.");
            }

        }
    }
}
