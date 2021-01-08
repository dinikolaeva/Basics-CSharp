using System;

namespace _6.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            const double basket = 1.50;
            const double wreath = 3.80;
            const double chocolateBunny = 7.00;

            int countOfClients = int.Parse(Console.ReadLine());

            double sumOfProducts = 0;
            double finalAmaunt = 0;
            double totalSum = 0;
            int counterOfProducts = 0;
            int count = 0;
            

            for (int client = 0; client < countOfClients; client++)
            {
                string typeOfProduct = Console.ReadLine();               

                while (typeOfProduct != "Finish")
                {

                    counterOfProducts++;
                    count++;

                    switch (typeOfProduct)
                    {
                        case "basket":
                            sumOfProducts += basket;
                            break;
                        case "wreath":
                            sumOfProducts += wreath;
                            break;
                        case "chocolate bunny":
                            sumOfProducts += chocolateBunny;
                            break;
                    }

                    totalSum += sumOfProducts;

                    typeOfProduct = Console.ReadLine();
                }

                if (count % 2 == 0)
                {
                    sumOfProducts -= sumOfProducts * 0.20;
                }

                finalAmaunt += sumOfProducts;

                if (typeOfProduct == "Finish")
                {
                    Console.WriteLine($"You purchased {count} items for {sumOfProducts:f2} leva.");
                }

                count = 0;
                sumOfProducts = 0;
            }

            double averageBill = finalAmaunt / countOfClients;

            Console.WriteLine($"Average bill per client is: {averageBill:f2} leva.");
        }
    }
}
