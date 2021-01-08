using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allQuantityOfFood = double.Parse(Console.ReadLine());

            int dogFood = 0;
            int catFood = 0;
            double eatenBiscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                int quantityOfFoodForDog = int.Parse(Console.ReadLine());
                int quantityOfFoodForCat = int.Parse(Console.ReadLine());

                    dogFood += quantityOfFoodForDog;
                    catFood += quantityOfFoodForCat;

                if (i % 3 == 0)
                {
                    eatenBiscuits += (quantityOfFoodForDog + quantityOfFoodForCat) * 0.10;
                }
            }
            
            double allEatenFood = dogFood + catFood;
            double percentAllEatenFood = (allEatenFood / allQuantityOfFood) * 100;
            double percentDogEat = (dogFood / allEatenFood) * 100;
            double percentCatEat = (catFood / allEatenFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(eatenBiscuits)}gr.");
            Console.WriteLine($"{percentAllEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDogEat:F2}% eaten from the dog.");
            Console.WriteLine($"{percentCatEat:f2}% eaten from the cat.");
        }
    }
}
