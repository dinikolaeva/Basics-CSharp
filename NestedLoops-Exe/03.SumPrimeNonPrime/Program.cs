using System;

namespace _3.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while (number != "stop")
            {
                int parseNumber = int.Parse(number);

                int counter = 0;

                if (parseNumber < 0)
                {
                    parseNumber = 0;
                    Console.WriteLine("Number is negative.");
                }

                    for (int i = 2; i <= parseNumber; i++)
                    {
                        if (parseNumber % i == 0)
                        {
                        counter++;
                        }
                    }

                if (counter == 1)
                {
                    primeSum += parseNumber;
                }
                else
                {
                    nonPrimeSum += parseNumber;
                }

                number = Console.ReadLine();
            }

            if (number == "stop")
            {
                Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
                Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
            }
        }
    }
}
