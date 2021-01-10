using System;

namespace _05.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;

            for (int i = 1; i <= number; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    countP1++;
                }
                if (input % 3 == 0)
                {
                    countP2++;
                }
                if (input % 4 == 0)
                {
                    countP3++;
                }
            }

            double percentP1 = countP1 * 1.0 / number * 100;
            double percentP2 = countP2 * 1.0 / number * 100;
            double percentP3 = countP3 * 1.0 / number * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}% ");
            Console.WriteLine($"{percentP3:f2}% ");
        }
    }
}
