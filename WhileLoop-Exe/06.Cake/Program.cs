using System;
using System.Drawing;

namespace _6.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeLeft = width * lenght;
            int parceCount = 0;
            string countOfPieces = Console.ReadLine();

            while (countOfPieces != "STOP")
            {
                parceCount = int.Parse(countOfPieces);

                cakeLeft -= parceCount;

                if (cakeLeft<=0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeLeft)} pieces more.");
                    break;
                }

                countOfPieces = Console.ReadLine();
            }

            if(countOfPieces == "STOP")
            {
                Console.WriteLine($"{cakeLeft} pieces are left.");
            }
        }
    }
}
