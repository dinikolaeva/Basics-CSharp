using System;

namespace _1.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;
            bool isBigger = false;

            for (int lines = 1; lines <= n; lines++)
            {
                for (int nubmers = 1; nubmers <= lines; nubmers++)
                {
                    if (counter > n)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write(counter + " ");
                    counter++;
                }

                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
