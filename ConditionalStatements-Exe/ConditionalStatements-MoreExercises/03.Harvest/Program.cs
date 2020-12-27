using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grape = x * y;
            double wine = (grape * 0.40) / 2.5;

            if (wine >= z)
            {
                double litreLeft = wine - z;
                double forWorkers = litreLeft / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litreLeft)} liters left -> {Math.Ceiling(forWorkers)} liters per person.");
            }
            else
            {
                double neededLitres = z - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitres)} liters wine needed.");
            }

        }
    }
}
