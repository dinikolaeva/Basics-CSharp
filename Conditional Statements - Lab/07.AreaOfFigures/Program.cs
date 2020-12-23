using System;

namespace _07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();

            if (typeOfFigure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(typeOfFigure);
                Console.WriteLine($"{a * a:F3}");
            }
            else if (typeOfFigure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(typeOfFigure);
                Console.WriteLine($"{a * b:F3}");
            }
            else if (typeOfFigure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(typeOfFigure);
                Console.WriteLine($"{Math.PI * a * a:F3}");
            }
            else if (typeOfFigure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(typeOfFigure);
                Console.WriteLine($"{a / 2 * b:F3}");
            }
        }
    }
}
