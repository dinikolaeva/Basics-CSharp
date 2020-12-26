using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int enteredNumbers = int.Parse(Console.ReadLine());

                if (enteredNumbers<minNumber)
                {
                    minNumber = enteredNumbers;
                }
                if (enteredNumbers>maxNumber)
                {
                    maxNumber = enteredNumbers;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
