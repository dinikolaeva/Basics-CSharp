using System;

namespace _002.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseA = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triangleArea = baseA * height / 2;

            Console.WriteLine($"{triangleArea:F2}");
        }
    }
}
