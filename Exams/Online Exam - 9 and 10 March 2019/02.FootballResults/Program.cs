using System;

namespace _02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstResult = Console.ReadLine();
            string secontResult = Console.ReadLine();
            string thirdResult = Console.ReadLine();

            int win = 0;
            int lose = 0;
            int drawn = 0;


            if (firstResult[0] > firstResult[2])
            {
                win += 1;
            }
            else if(firstResult[0] < firstResult[2])
            {
                lose += 1;
            }

            if (secontResult[0] > secontResult[2])
            {
                win += 1;
            }
            else if(secontResult[0] < secontResult[2])
            {
                lose += 1;
            }

            if (thirdResult[0] > thirdResult[2])
            {
                win += 1;
            }
            else if(thirdResult[0] < thirdResult[2])
            {
                lose += 1;
            }

            if (firstResult[0] == firstResult[2])
            {
                drawn += 1;
            }
            if (secontResult[0] == secontResult[2])
            {
                drawn += 1;
            }
            if (thirdResult[0] == thirdResult[2])
            {
                drawn += 1;
            }

            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lose} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
