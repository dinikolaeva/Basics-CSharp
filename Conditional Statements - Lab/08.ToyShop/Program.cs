using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // puzzle = 2.60;
            // doll = 3.00;
            // bear = 4.10;
            // minion = 8.20;
            // truck = 2.00;

            double travelPrice = double.Parse (Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double totalCount = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;

            double totalSum = (puzzlesCount * 2.60) +
                (dollsCount * 3.00) + (bearsCount * 4.10) + (minionsCount * 8.20) + (trucksCount * 2);

            if (totalCount >= 50)
            {
                totalSum = totalSum * 0.75;
            }
            //Rent
            totalSum *= 0.90;

            if (totalSum >= travelPrice)
            {
                double trip = totalSum - travelPrice;
                Console.WriteLine($"Yes! {trip:F2} lv left.");
            }
            else if(totalSum < travelPrice)
            {
                double trip = travelPrice - totalSum;
                Console.WriteLine($"Not enough money! {trip:F2} lv needed.");
            }


        }
    }
}
