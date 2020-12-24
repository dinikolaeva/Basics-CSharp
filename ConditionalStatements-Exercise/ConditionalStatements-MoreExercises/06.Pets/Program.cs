using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodGr = double.Parse(Console.ReadLine());

            double turtleFoodKg = turtleFoodGr / 1000;

            double dogFoodNeeded = days * dogFoodKg;
            double catFoodNeeded = days * catFoodKg;
            double turtleFoodNeeded = days * turtleFoodKg;

            double allFoodNeeded = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;

            if (allFoodNeeded <= leftFood)
            {
                double foodLeft = leftFood-allFoodNeeded;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodLeft = allFoodNeeded - leftFood;
                Console.WriteLine($"{Math.Ceiling(foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
