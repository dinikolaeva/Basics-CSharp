using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            const double converter = 1.00;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (double i = 0; i < number; i++)
            {
                int countNumber = int.Parse(Console.ReadLine());

                if (countNumber < 200)
                {
                    p1++;
                }
                else if (countNumber < 400)
                {
                    p2++;
                }
                else if (countNumber < 600)
                {
                    p3++;
                }
                else if (countNumber < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double pp1 = converter * p1 / number * 100;
            double pp2 = converter * p2 / number * 100;
            double pp3 = converter * p3 / number * 100;
            double pp4 = converter * p4 / number * 100;
            double pp5 = converter * p5 / number * 100;

            Console.WriteLine($"{pp1:f2}%");
            Console.WriteLine($"{pp2:f2}%");
            Console.WriteLine($"{pp3:f2}%");
            Console.WriteLine($"{pp4:f2}%");
            Console.WriteLine($"{pp5:f2}%");
        }
    }
}
