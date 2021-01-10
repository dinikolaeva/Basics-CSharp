using System;

namespace _01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double deckChairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double sumOfEntranceFee = countOfPeople * entranceFee;
            double percentOfDeckChairs = Math.Ceiling(countOfPeople * 0.75);
            double percentOfUmbrellas = Math.Ceiling(countOfPeople * 0.50);
            double sumOfDeckChair = percentOfDeckChairs * deckChairPrice;
            double sumOfUmbrellas = percentOfUmbrellas * umbrellaPrice;

            double totalSum = sumOfEntranceFee + sumOfDeckChair + sumOfUmbrellas;

            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}
