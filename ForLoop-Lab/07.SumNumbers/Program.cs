using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sumOfNumbers = 0;

            for (int i = 0; i < numbers; i++)
            {
                int enteredNumbers = int.Parse(Console.ReadLine());
                sumOfNumbers += enteredNumbers;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
