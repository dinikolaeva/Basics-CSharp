using System;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTournament = int.Parse(Console.ReadLine());

            double sumOfSportForCharity = 0;
            double sumOfDay = 0;
            double sumOfAllTournament = 0;
            int win = 0;
            int lose = 0;
            int winCount = 0;
            int loseCount = 0;
            int winDayCount = 0;
            int loseDayCount = 0;

            for (int day = 1; day <= daysOfTournament; day++)
            {
                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        win++;
                        winCount++;
                        sumOfSportForCharity += 20;
                    }
                    else
                    {
                        lose++;
                        loseCount++;
                    }

                    sport = Console.ReadLine();
                }

                sumOfDay += sumOfSportForCharity;

                if (win > lose)
                {
                    sumOfDay += sumOfDay * 0.10;
                }

                if (winCount > loseCount)
                {
                    winDayCount++;
                }
                else
                {
                    loseDayCount++;
                }

                sumOfAllTournament += sumOfDay;

                sumOfDay = 0;
                sumOfSportForCharity = 0;
                win = 0;
                lose = 0;
            }

            if (winDayCount > loseDayCount)
            {
                sumOfAllTournament += sumOfAllTournament * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {sumOfAllTournament:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {sumOfAllTournament:f2}");
            }
        }
    }
}
