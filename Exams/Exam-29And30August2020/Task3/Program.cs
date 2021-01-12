using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputSum = double.Parse(Console.ReadLine());
            string tours = Console.ReadLine();
            string fanCard = Console.ReadLine();
            string typeOfKart = Console.ReadLine();

            double priceForTours = 0;

            switch (typeOfKart)
            {
                case "Child":
                    if (tours == "five")
                    {
                        priceForTours = 7;
                    }
                    else
                    {
                        priceForTours = 11;
                    }
                    break;
                case "Junior":
                    if (tours == "five")
                    {
                        priceForTours = 9;
                    }
                    else
                    {
                        priceForTours = 16;
                    }
                    break;
                case "Adult":
                    if (tours == "five")
                    {
                        priceForTours = 12;
                    }
                    else
                    {
                        priceForTours = 21;
                    }
                    break;
                case "Profi":
                    if (tours == "five")
                    {
                        priceForTours = 18;
                    }
                    else
                    {
                        priceForTours = 32;
                    }
                    break;
            }

            if (fanCard == "yes")
            {
                priceForTours -= priceForTours * 0.20;
            }

            if (priceForTours <= inputSum)
            {
                double leftMoney = inputSum - priceForTours;
                Console.WriteLine($"You bought {typeOfKart} ticket for {tours} laps. Your change is {leftMoney:f2}lv.");
            }
            else
            {
                double neededMoney = priceForTours - inputSum;
                Console.WriteLine($"You don't have enough money! You need {neededMoney:f2}lv more.");
            }
        }
    }
}
