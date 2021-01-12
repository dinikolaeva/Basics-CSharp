using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int number = M; number >= N; number--)
            {
                if (number % 2 == 0 && number % 3 == 0)
                {
                    if (number == S)
                    {
                        break;
                    }

                    Console.Write(number + " ");
                }
            }
        }
    }
}
