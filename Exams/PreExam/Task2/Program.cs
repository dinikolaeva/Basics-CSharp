using System;

namespace Contest2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeopleInGroup = int.Parse(Console.ReadLine());
            int powerOfOneMan = int.Parse(Console.ReadLine());
            int bloodOfIlidan = int.Parse(Console.ReadLine());

            int allPowerOfPlayers = countPeopleInGroup * powerOfOneMan;


            if (allPowerOfPlayers >= bloodOfIlidan)
            {
                int pointsOverload = allPowerOfPlayers - bloodOfIlidan;
                Console.WriteLine($"Illidan has been slain! You defeated him with {pointsOverload} points.");
            }
            else
            {
                int pointsNeeded = bloodOfIlidan - allPowerOfPlayers;
                Console.WriteLine($"You are not prepared! You need {pointsNeeded} more points.");
            }

        }
    }
}
