using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string nameOfProduct = Console.ReadLine();

            double leftSum = 0;
            double sumOfProducts = 0;
            int countOfProducts = 0;


            while (nameOfProduct != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());

                countOfProducts++;

                if (countOfProducts % 3 == 0)
                {
                    productPrice = productPrice / 2;
                }

                leftSum = budget - productPrice;

                if (leftSum < 0)
                {
                    double neededMoney = productPrice - budget;

                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {neededMoney:f2} leva!");
                    break;
                }

                budget = leftSum;
                sumOfProducts += productPrice;

                nameOfProduct = Console.ReadLine();
            }

            if (nameOfProduct == "Stop")
            {

                Console.WriteLine($"You bought {countOfProducts} products for {sumOfProducts:f2} leva.");

            }
        }
    }
}
