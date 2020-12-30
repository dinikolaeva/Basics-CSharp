using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            int diff = 0;


            for (int i = 1; i <= count; i++)
            {
                int enteredNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += enteredNum;
                }
                else
                {
                    oddSum += enteredNum;
                }
            }

                if (evenSum==oddSum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {evenSum}");
                }
                else
                {
                    diff = Math.Abs(evenSum - oddSum);
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {diff}");
                }

            }
        }
    }
