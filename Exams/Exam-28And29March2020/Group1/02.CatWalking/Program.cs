using System;

namespace _2.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int countOfWalkings = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int allMinutesPerDay = minutes * countOfWalkings;
            int caloriesPerDay = allMinutesPerDay * 5;
            int burnedCalories = calories / 2;



            if (caloriesPerDay>=burnedCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesPerDay}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesPerDay}.");
            }
        }
    }
}
