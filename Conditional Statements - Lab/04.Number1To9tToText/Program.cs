using System;

namespace _04.Number1To9tToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <=99)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
