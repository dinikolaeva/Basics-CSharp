using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakePrice = 45.0;
            double wafflePrice = 5.8;
            double pancakePrice = 3.2;

            int dayOfCampaign = int.Parse(Console.ReadLine());
            int countOfCoocers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sumFromCakes = cakes * cakePrice;
            double sumFromWaffles = waffles * wafflePrice;
            double sumFromPancakes = pancakes * pancakePrice;
            double totalSumPerDay = (sumFromCakes + sumFromWaffles + sumFromPancakes) * countOfCoocers;
            double allCampaignSum = totalSumPerDay * dayOfCampaign;
            double totalSum = allCampaignSum - (allCampaignSum / 8);


            Console.WriteLine(totalSum);

        }
    }
}
