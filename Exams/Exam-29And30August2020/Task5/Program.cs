using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfRacer = Console.ReadLine();

            int goldCard = 0;
            int silverCard = 0;
            int bronzeCard = 0;

            int minResult = int.MaxValue;
            string winner = "";
            int winnerMinutes = 0;
            int winnerSeconds = 0;

            while (nameOfRacer != "Finish")
            {
                int minutes = int.Parse(Console.ReadLine());
                int seconds = int.Parse(Console.ReadLine());

                seconds += minutes * 60;


                if (seconds < 55)
                {
                    goldCard++;
                }
                else if (seconds >= 55 && seconds <= 85)
                {
                    silverCard++;
                }
                else if (seconds > 85 && seconds <= 120)
                {
                    bronzeCard++;
                }

                if (seconds < minResult)
                {
                    minResult = seconds;
                    winner = nameOfRacer;
                    winnerMinutes = seconds / 60;
                    winnerSeconds = seconds % 60;
                }

                nameOfRacer = Console.ReadLine();

                if (nameOfRacer == "Finish")
                {
                    Console.WriteLine($"With {winnerMinutes} minutes and {winnerSeconds} seconds {winner} is the winner of the day!");
                    Console.WriteLine($"Today's prizes are {goldCard} Gold {silverCard} Silver and {bronzeCard} Bronze cards!");
                }
            }
        }
    }
}
