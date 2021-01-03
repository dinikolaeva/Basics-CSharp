using System;

namespace _02._2ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfCharity = int.Parse(Console.ReadLine());

            string priceOfProducts = Console.ReadLine();

            int input = 0;
            int counter = 0;
            int counterCS = 0;
            int counterCC = 0;
            int totalCS = 0;
            int totalCC = 0;
            double convertor = 1.0;

            while (priceOfProducts != "End")
            {
                input = int.Parse(priceOfProducts);
                counter++;

                if (counter % 2 != 0)
                {
                    if (input > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        counterCS++;
                        totalCS += input;
                    }
                }
                else if (counter % 2 == 0)
                {
                    if (input < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        counterCC++;
                        totalCC += input;
                    }

                    int totalSum = totalCS + totalCC;

                    if (totalSum >= sumOfCharity)
                    {
                        double averageCS = convertor * totalCS / counterCS;
                        double averrageCC = convertor * totalCC / counterCC;
                        Console.WriteLine($"Average CS: {averageCS:f2}");
                        Console.WriteLine($"Average CC: {averrageCC:f2}");
                        break;
                    }

                }

                priceOfProducts = Console.ReadLine();
            }

            if (priceOfProducts == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
