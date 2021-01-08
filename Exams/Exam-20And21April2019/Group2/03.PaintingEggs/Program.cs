using System;
using System.Threading.Tasks;

namespace _3.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeOfEggs = Console.ReadLine();
            string colourOfEggs = Console.ReadLine();
            int batchOfEggs = int.Parse(Console.ReadLine());

            double priceOfOneBatch = 0;

            //                     Червено(Red)   Зелено(Green)  Жълто(Yellow)
            //Големи(Large)           16 лв.           12 лв.         9 лв.
            //Средни(Medium)          13 лв.            9 лв.         7 лв.
            //Малки(Small)             9 лв.            8 лв.         5 лв.

            switch (sizeOfEggs)
            {
                case "Large":

                    if (colourOfEggs == "Red")
                    {
                        priceOfOneBatch = 16;
                    }
                    else if (colourOfEggs == "Green")
                    {
                        priceOfOneBatch = 12;
                    }
                    else
                    {
                        priceOfOneBatch = 9;
                    }
                    break;
                case "Medium":
                    if (colourOfEggs == "Red")
                    {
                        priceOfOneBatch = 13;
                    }
                    else if (colourOfEggs == "Green")
                    {
                        priceOfOneBatch = 9;
                    }
                    else
                    {
                        priceOfOneBatch = 7;
                    }
                    break;
                case "Small":
                    if (colourOfEggs == "Red")
                    {
                        priceOfOneBatch = 9;
                    }
                    else if (colourOfEggs == "Green")
                    {
                        priceOfOneBatch = 8;
                    }
                    else
                    {
                        priceOfOneBatch = 5;
                    }
                    break;
            }

            double priceOfAllBatch = priceOfOneBatch * batchOfEggs;

            double totalSum = priceOfAllBatch - (priceOfAllBatch * 0.35);

            Console.WriteLine($"{totalSum:f2} leva.");
        }
    }
}
