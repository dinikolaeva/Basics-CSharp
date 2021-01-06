using System;

namespace _05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int W = 2000;
            const int F = 1200;
            const int SF = 720;

            int countOfTournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int sumOfPoints = 0;
            int countOfWins = 0;

            for (int tournament = 0; tournament < countOfTournaments; tournament++)
            {
                string stageOfTheTournament = Console.ReadLine();


                if (stageOfTheTournament == "W")
                {
                    startPoints += W;
                    sumOfPoints += W;
                    countOfWins++;
                }
                else if (stageOfTheTournament == "F")
                {
                    startPoints += F;
                    sumOfPoints += F;
                }
                else
                {
                    startPoints += SF;
                    sumOfPoints += SF;
                }

            }

            double averagePoints = sumOfPoints / countOfTournaments;
            double percentOfWinTournaments = (countOfWins * 1.0 / countOfTournaments) * 100;

            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentOfWinTournaments:f2}%");
        }
    }
}
