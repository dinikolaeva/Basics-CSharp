using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            const double bunchOfStrawberries = 3.50;
            const double bunchOfBlueberries = 5.00;

            int countOfBunchOfStrawberries = 0;
            int countOfBunchOfBlueberries = 0;

            int countOfRows = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            for (int row = 1; row <= countOfRows; row++)
            {
                for (int newPosition = 1; newPosition <= position; newPosition++)
                {
                    if (row % 2 != 0)
                    {
                        countOfBunchOfStrawberries++;
                    }
                    else if (row % 2 == 0 && newPosition % 3 != 0)
                    {
                        countOfBunchOfBlueberries++;
                    }
                }
            }

            double strawberriesSum = countOfBunchOfStrawberries * bunchOfStrawberries;
            double blueberriesSum = countOfBunchOfBlueberries * bunchOfBlueberries;
            double allSum = strawberriesSum + blueberriesSum;

            double totalSum = allSum * 0.80;

            Console.WriteLine($"Total: {totalSum:F2} lv.");
        }
    }
}
