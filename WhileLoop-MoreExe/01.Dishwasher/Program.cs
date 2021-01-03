using System;

namespace _01._1Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            const int liquid = 750;
            const int oneDish = 5;
            const int pot = 15;

            int countBottlesOfLiquid = int.Parse(Console.ReadLine());

            int quantityOfLiquid = countBottlesOfLiquid * liquid;
            int counter = 0;
            int usedLiquid = 0;
            int sumOfDishes = 0;
            int sumOfPots = 0;

            string dishes = Console.ReadLine();

            while (dishes != "End")
            {
                int parseDishes = int.Parse(dishes);
                counter++;

                if (counter % 3 != 0)
                {
                    sumOfDishes += parseDishes;

                    usedLiquid = parseDishes * oneDish;
                    quantityOfLiquid -= usedLiquid;

                }
                else if (counter % 3 == 0)
                {
                    sumOfPots += parseDishes;
                    usedLiquid = parseDishes * pot;
                    quantityOfLiquid -= usedLiquid;
                }

                if (quantityOfLiquid < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(quantityOfLiquid)} ml. more necessary!");
                    break;
                }

                dishes = Console.ReadLine();
            }

            if (dishes == "End" && quantityOfLiquid >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{sumOfDishes} dishes and {sumOfPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {quantityOfLiquid} ml.");

            }
        }
    }
}
