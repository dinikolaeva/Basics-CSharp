using System;

namespace _06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredHeight = int.Parse(Console.ReadLine());

            int heightFromJump = 0;
            int startJumps = requiredHeight - 30;
            int sumOfHeightChange = requiredHeight;

            int countOfNotSuccesfulAttempts = 0;
            int countOfSuccesfulAttempts = 0;

            while (true)
            {
                heightFromJump = int.Parse(Console.ReadLine());
                countOfSuccesfulAttempts++;

                if (heightFromJump > startJumps)
                {
                    if (heightFromJump >= sumOfHeightChange)
                    {
                        break;
                    }

                    startJumps += 5;
                    countOfNotSuccesfulAttempts = 0;
                }
                else if (heightFromJump <= startJumps)
                {
                    countOfNotSuccesfulAttempts++;
                }

                if (countOfNotSuccesfulAttempts == 3)
                {
                    Console.WriteLine($"Tihomir failed at {startJumps}cm after {countOfSuccesfulAttempts} jumps.");
                    return;
                }
            }

            Console.WriteLine($"Tihomir succeeded, he jumped over {startJumps}cm after {countOfSuccesfulAttempts} jumps.");
        }
    }
}
