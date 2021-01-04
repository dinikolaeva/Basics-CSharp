using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int validCombinations = 0;

            for (int combination1 = 0; combination1 <= n; combination1++)
            {
                for (int combination2 = 0; combination2 <= n; combination2++)
                {
                    for (int combination3 = 0; combination3 <= n; combination3++)
                    {
                        if (combination1 + combination2 + combination3 == n)
                        {
                            validCombinations++;
                        }
                    }
                }
            }

            Console.WriteLine(validCombinations);
        }
    }
}
