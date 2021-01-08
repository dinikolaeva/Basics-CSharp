using System;

namespace _5.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfEasterBreads = int.Parse(Console.ReadLine());

            int allSumOfShugar = 0;
            int allSumOfFlour = 0;
            int maxShugar = int.MinValue;
            int maxFlour = int.MinValue;

            for (int easterBread = 1; easterBread <= countOfEasterBreads; easterBread++)
            {
                int gramsOfShugar = int.Parse(Console.ReadLine());
                int gramsOfFlour = int.Parse(Console.ReadLine());

                allSumOfShugar += gramsOfShugar;
                allSumOfFlour += gramsOfFlour;

                if (gramsOfShugar > maxShugar)
                {
                    maxShugar = gramsOfShugar;
                }

                if (gramsOfFlour > maxFlour)
                {
                    maxFlour = gramsOfFlour;
                }

            }

            double countOfPacksShugar = 1.0 * allSumOfShugar / 950;
            double countOfPacksFlour = 1.0 * allSumOfFlour / 750;

            Console.WriteLine($"Sugar: {Math.Ceiling(countOfPacksShugar)}");
            Console.WriteLine($"Flour: {Math.Ceiling(countOfPacksFlour)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxShugar} grams.");
        }
    }
}
