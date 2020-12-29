using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strowberriesPrice = double.Parse(Console.ReadLine());
            double raspberriesPrice = strowberriesPrice / 2;
            double orangesPrice = raspberriesPrice * 0.40;
            double bananasPrice = raspberriesPrice * 0.80;

            double bananasAmaunt = double.Parse(Console.ReadLine());
            double orangesAmaunt = double.Parse(Console.ReadLine());
            double raspberriesAmaunt = double.Parse(Console.ReadLine());
            double strowberriesAmaunt = double.Parse(Console.ReadLine());

            double raspberriesPricePerKg = strowberriesPrice / 2;
            double orangesAmountPerKg = raspberriesPrice - orangesPrice;
            double bananasAmountPerKg = raspberriesPrice - bananasPrice;
            double raspberriesSum = raspberriesPricePerKg * raspberriesAmaunt;
            double orangesSum = orangesAmountPerKg * orangesAmaunt;
            double bananaSum = bananasAmountPerKg * bananasAmaunt;
            double strowberriesSum = strowberriesAmaunt * strowberriesPrice;
            double totalSumMaria = raspberriesSum + orangesSum + bananaSum + strowberriesSum; 

            Console.WriteLine($"{totalSumMaria:F2}");
        }
    }
}
