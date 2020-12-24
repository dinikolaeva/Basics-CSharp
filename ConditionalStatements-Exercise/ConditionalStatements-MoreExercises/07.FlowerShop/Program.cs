using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Магнолии – 3.25 лева
            // Зюмбюли – 4 лева
            // Рози – 3.50 лева
            // Кактуси – 8 лева

            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());


            double magnolias = 3.25;
            double hyacinths = 4.00;
            double roses = 3.50;
            double cactuses = 8.00;

            double magnoliasTotalPrice = magnolias * magnoliasCount;
            double hyacinthsTotalPrice = hyacinths * hyacinthsCount;
            double rosesTotalPrice = roses * rosesCount;
            double cactusesTotalPrice = cactuses * cactusesCount;

            double totalPrice = magnoliasTotalPrice + hyacinthsTotalPrice + rosesTotalPrice + cactusesTotalPrice;

            // fee 5% from allSum

            totalPrice = totalPrice - (totalPrice * 0.05);

            if (totalPrice>=presentPrice)
            {
                double moneyLeft = totalPrice - presentPrice;
                Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
            }
            else
            {
                double moneyBorrow = presentPrice - totalPrice;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyBorrow)} leva.");
            }
        }
    }
}
