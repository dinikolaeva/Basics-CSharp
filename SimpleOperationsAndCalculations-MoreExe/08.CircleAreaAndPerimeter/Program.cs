using System;

namespace _008.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double s = Math.PI * (r * r);

            double p = 2 * Math.PI * r;

            Console.WriteLine($"{s:F2}");
            Console.WriteLine($"{p:F2}");
        }
    }
}
