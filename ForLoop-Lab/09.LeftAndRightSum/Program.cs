using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int diff = 0;

            for (int i = 0; i < number; i++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                leftSum += leftNum;
            }

            for (int i = 0; i < number; i++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                rightSum +=rightNum;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($" Yes, sum = {leftSum}");
            }
            else
            {
                diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
