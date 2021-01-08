using System;

namespace _04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfFirstPlayer = Console.ReadLine();
            string nameOfSecondPlayer = Console.ReadLine();
            string cardFromFirstPlayer = Console.ReadLine();

            int pointsPlayer1 = 0;
            int pointsPlayer2 = 0;
            int sumOfPointsPlayer1 = 0;
            int sumOfPointsPlayer2 = 0;

            while (cardFromFirstPlayer != "End of game")
            {
                int parceCardPlayer1 = int.Parse(cardFromFirstPlayer);
                int cardFromSecondPlayer = int.Parse(Console.ReadLine());

                if (parceCardPlayer1 > cardFromSecondPlayer)
                {
                    pointsPlayer1 = parceCardPlayer1 - cardFromSecondPlayer;
                    sumOfPointsPlayer1 += pointsPlayer1;
                }
                else if (parceCardPlayer1 < cardFromSecondPlayer)
                {
                    pointsPlayer2 = cardFromSecondPlayer - parceCardPlayer1;
                    sumOfPointsPlayer2 += pointsPlayer2;
                }

                if (parceCardPlayer1 == cardFromSecondPlayer)
                {
                    Console.WriteLine("Number wars!");

                    int newCardPlayer1 = int.Parse(Console.ReadLine());
                    int newCardPlayer2 = int.Parse(Console.ReadLine());

                    if (newCardPlayer1 > newCardPlayer2)
                    {
                        Console.WriteLine($"{nameOfFirstPlayer} is winner with {sumOfPointsPlayer1} points");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfSecondPlayer} is winner with {sumOfPointsPlayer2} points");
                        break;
                    }               
                }

                cardFromFirstPlayer = Console.ReadLine();
            }

            if (cardFromFirstPlayer == "End of game")
            {
                Console.WriteLine($"{nameOfFirstPlayer} has {sumOfPointsPlayer1} points");
                Console.WriteLine($"{nameOfSecondPlayer} has {sumOfPointsPlayer2} points");
            }
        }
    }
}
