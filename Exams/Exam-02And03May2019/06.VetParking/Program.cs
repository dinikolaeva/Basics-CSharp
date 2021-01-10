using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double parkingPrice = 0;
            double sumOfDay = 0;
            double totalSum = 0;

            for (int i = 1; i <= days; i++)
            {

                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        parkingPrice += 2.50;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        parkingPrice += 1.25;
                    }
                    else
                    {
                        parkingPrice += 1;
                    }
                }

                sumOfDay += parkingPrice;
                Console.WriteLine($"Day: {i} - {sumOfDay:F2} leva");
                totalSum += sumOfDay;

                parkingPrice = 0;
                sumOfDay = 0;
            }

            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
