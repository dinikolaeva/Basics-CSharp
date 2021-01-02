using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (input!="Stop")
            {
                int number = int.Parse(input);

                if (number<minNumber)
                {
                    minNumber = number;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
