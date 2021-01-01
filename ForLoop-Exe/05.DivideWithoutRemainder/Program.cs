using System;

namespace _005.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            const double converter = 1.0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;


            for (int i = 0; i < number; i++)
            {
                int enteredNumbers = int.Parse(Console.ReadLine());

                if (enteredNumbers % 2 == 0)
                {
                    p1++;
                }
                if (enteredNumbers % 3 == 0)
                {
                    p2++;
                }
                if (enteredNumbers % 4 == 0)
                {
                    p3++;
                }
            }

            double pp1 = converter * p1 / number * 100;
            double pp2 = converter * p2 / number * 100;
            double pp3 = converter * p3 / number * 100;

            Console.WriteLine($"{pp1:f2}%");
            Console.WriteLine($"{pp2:f2}%");
            Console.WriteLine($"{pp3:f2}%");
        }
    }
}
