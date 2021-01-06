using System;

namespace _2.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {

                string number = i.ToString();

                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    int currentNumber = int.Parse(number[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentNumber;
                    }
                    else
                    {
                        oddSum += currentNumber;
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
