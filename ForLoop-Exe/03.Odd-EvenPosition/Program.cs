using System;

namespace _003.Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNum = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;


            for (int i = 1; i <= enterNum; i++)
            {
                double countNum = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += countNum;

                    if (countNum > oddMax)
                    {
                        oddMax = countNum;
                    }

                    if (countNum < oddMin)
                    {
                        oddMin = countNum;
                    }

                }
                else
                {
                    evenSum += countNum;
                    if (countNum > evenMax)
                    {
                        evenMax = countNum;
                    }

                    if (countNum < evenMin)
                    {
                        evenMin = countNum;
                    }

                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin < double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
            }
            if (oddMax > double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine($"OddMax=No,");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin < double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
            }
            if (evenMax > double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
