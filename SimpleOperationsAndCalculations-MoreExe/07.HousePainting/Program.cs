using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _007.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //green paint 1l = 3.4 kvm
            //red paint 1l = 4.3 kvm

            double greenPaint = 1 * 3.40;
            double redPaint = 1 * 4.30;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //walls

            double sideWall = x * y;
            double window = 1.50 * 1.50;
            double twoSideWalls = (2 * sideWall) - (2 * window);
            double backWall = x * x;
            double enter = 2 * 1.20;
            double backFrontWalls = (2 * backWall) - enter;
            double totalArea = twoSideWalls + backFrontWalls;
            double greenPaintForWalls = totalArea / greenPaint;

            //roof

            double rectangles = 2 * (x * y);
            double triangles = 2 * ((x * h) / 2);
            double totalAreaRoof = rectangles + triangles;
            double redPaintForRoof = totalAreaRoof / 4.30;

            Console.WriteLine($"{greenPaintForWalls:F2}");
            Console.WriteLine($"{redPaintForRoof:F2}");
        }
    }
}
