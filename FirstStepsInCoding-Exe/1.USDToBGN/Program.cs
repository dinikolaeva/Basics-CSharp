using System;

namespace MoneyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double courseUsdToBgn = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * courseUsdToBgn;

            Console.WriteLine($"{bgn:F2}");


        }
    }
}
