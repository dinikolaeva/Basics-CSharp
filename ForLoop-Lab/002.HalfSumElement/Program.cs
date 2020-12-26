using System;

namespace _002.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfCounts = 0;
            int diff = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int count = int.Parse(Console.ReadLine());

                sumOfCounts += count;

                if (maxNumber<count)
                {
                    maxNumber = count;
                }

            }

            int diffBetweenMaxAndSum = sumOfCounts-maxNumber;
            if (maxNumber == diffBetweenMaxAndSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {diffBetweenMaxAndSum}");
            }
            else
            {
                diff = maxNumber - diffBetweenMaxAndSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)} ");
            }
        }
    }
}
