using System;

namespace _5.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodinKilos = int.Parse(Console.ReadLine()); // kg
            string eatenQuantityOfFood = Console.ReadLine(); // gr

            int sumOfGrams = 0;
            int foodInGrams = foodinKilos * 1000;

            while (eatenQuantityOfFood != "Adopted")
            {
                int eatenGrams = int.Parse(eatenQuantityOfFood);

                sumOfGrams += eatenGrams;

                eatenQuantityOfFood = Console.ReadLine();
            }

            if (foodInGrams > sumOfGrams || foodInGrams == sumOfGrams)
            {
                int leftoverGrams = foodInGrams - sumOfGrams;
                Console.WriteLine($"Food is enough! Leftovers: {leftoverGrams} grams.");
            }
            else
            {
                int neededFood = sumOfGrams - foodInGrams;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
        }
    }
}
