using System;
using System.Reflection.Metadata.Ecma335;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double porcent = double.Parse(Console.ReadLine());

            double litresToCubicDecimeter = 0.001;

            double capacityOfTank = lenght * widht * height;
            double litresFullTank = capacityOfTank * litresToCubicDecimeter;
            double porcentForTank = porcent * 0.01;
            double totalLitresOfWater = litresFullTank * (1 - porcentForTank);

            Console.WriteLine(totalLitresOfWater);

        }
    }
}
