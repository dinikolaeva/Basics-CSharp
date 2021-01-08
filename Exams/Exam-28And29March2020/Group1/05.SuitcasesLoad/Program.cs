using System;

namespace _05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double planeCapacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int suitcaseCounter = 0;

            while (planeCapacity >= 0)
            {
                if (input == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }
                double suitcaseVolume = double.Parse(input);

                if ((suitcaseCounter + 1) % 3 == 0)
                {
                    suitcaseVolume = suitcaseVolume * 1.1;
                }

                if (planeCapacity <= suitcaseVolume)
                {
                    Console.WriteLine("No more space!");
                    break;
                }

                suitcaseCounter++;
                planeCapacity -= suitcaseVolume;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
        }
    }
}