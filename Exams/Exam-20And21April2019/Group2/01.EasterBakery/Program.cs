using System;

namespace _1.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double kilosOfFlour = double.Parse(Console.ReadLine());
            double kilosOfShugar = double.Parse(Console.ReadLine());
            int countOfDozensOfEggs = int.Parse(Console.ReadLine());
            int mayPackage = int.Parse(Console.ReadLine());

            double shugarPrice = flourPrice - (flourPrice * 0.25);
            double eggsPrice = flourPrice + (flourPrice * 0.10);
            double mayPrice = shugarPrice - (shugarPrice * 0.80);

            double sumOfFlour = kilosOfFlour * flourPrice;
            double sumOfShugar = kilosOfShugar * shugarPrice;
            double sumOfEggs = countOfDozensOfEggs * eggsPrice;
            double sumOfMay = mayPackage * mayPrice;

            double totalSum = sumOfFlour + sumOfShugar + sumOfEggs + sumOfMay;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
