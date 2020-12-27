using System;
using System.Security;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double v = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());

            double volumeP1 = p1 * n;
            double volumeP2 = p2 * n;
            double sumVolume = volumeP1 + volumeP2;

            if (sumVolume <= v)
            {
                double percentFull = (sumVolume / v) * 100;
                double p1Percent = (volumeP1 / sumVolume)  * 100;
                double p2Percent = (volumeP2 / sumVolume) * 100;
                Console.WriteLine($"The pool is {percentFull:F2} % full. Pipe 1: {p1Percent:F2} %. Pipe 2: {p2Percent:F2} %.");
            }
            else
            {
                double litresOverflow = sumVolume - v;
                Console.WriteLine($"For {n:F2} hours the pool overflows with {litresOverflow:F2} liters.");
                    
            }

        }
    }
}
