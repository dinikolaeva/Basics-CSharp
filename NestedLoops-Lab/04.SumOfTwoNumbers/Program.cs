using System;
using System.Security.Cryptography;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool isMagic = false;
            int counter = 0;

            for (int combination1 = start; combination1 <= end; combination1++)
            {
                for (int combination2 = start; combination2 <= end; combination2++)
                {
                    counter++;


                    if (combination1 + combination2 == magicNumber)
                    {
                        isMagic = true;
                        Console.WriteLine($"Combination N:{counter} ({combination1} + {combination2} = {magicNumber})");
                        return;
                    }
                }
            }

            if(!isMagic)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
