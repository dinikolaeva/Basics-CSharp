using System;
using System.Collections.Concurrent;
using System.Diagnostics.Tracing;

namespace _01._5AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = 0; i < input; i++)
            {
                int number = int.Parse(Console.ReadLine());
                counter++;
                sum += number;
            }

            double averageNumber = 1.0 * sum / counter;
            Console.WriteLine($"{averageNumber:f2}");
        }
    }
}
