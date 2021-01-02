using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string boxes = Console.ReadLine();

            int freeSpace = width * lenght * hight;

            while (boxes != "Done")
            {

                freeSpace -= int.Parse(boxes);

                if (freeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }

                boxes = Console.ReadLine();
            }

            if (boxes == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
