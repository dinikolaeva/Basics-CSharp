using System;

namespace Contest1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dollarInLeva = 1.57;

            double processorPrice = double.Parse(Console.ReadLine());
            double videoCardPrice = double.Parse(Console.ReadLine());
            double oneRamPrice = double.Parse(Console.ReadLine());
            int countOfRam = int.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());

            double processorPriceInLeva = processorPrice * dollarInLeva;
            double videoCardPriceInLeva = videoCardPrice * dollarInLeva;
            double oneRamPriceInLeva = oneRamPrice * dollarInLeva;
            double allPriceRam = oneRamPriceInLeva * countOfRam;
            double discountPriceOfProcessor = processorPriceInLeva - (processorPriceInLeva * discountPercent);
            double discountPriceOfVideoCard = videoCardPriceInLeva - (videoCardPriceInLeva * discountPercent);

            double totalSum = discountPriceOfProcessor + discountPriceOfVideoCard + allPriceRam;

            Console.WriteLine($"Money needed - {totalSum:f2} leva.");
        }
    }
}
