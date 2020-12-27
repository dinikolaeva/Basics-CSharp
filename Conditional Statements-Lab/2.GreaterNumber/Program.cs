using System;

namespace _02.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (number >= secondNumber)
            {
                Console.WriteLine(number);
            }
            else if (secondNumber >=number)
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
