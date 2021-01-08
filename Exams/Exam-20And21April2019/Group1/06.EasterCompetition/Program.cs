using System;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfEasterBreads = int.Parse(Console.ReadLine());

            int sumOfGrades = 0;
            int maxChefGrades = int.MinValue;
            string topChef = "";

            for (int newParticipiant = 0; newParticipiant < countOfEasterBreads; newParticipiant++)
            {

                string nameOfBaker = Console.ReadLine();
                string gradeForEasterBread = Console.ReadLine();
                sumOfGrades = 0;

                while (gradeForEasterBread != "Stop")
                {
                    int gradeParse = int.Parse(gradeForEasterBread);

                    sumOfGrades += gradeParse;

                    gradeForEasterBread = Console.ReadLine();
                }

                Console.WriteLine($"{nameOfBaker} has {sumOfGrades} points.");

                if (sumOfGrades > maxChefGrades)
                {
                    maxChefGrades = sumOfGrades;
                    topChef = nameOfBaker;
                    Console.WriteLine($"{topChef} is the new number 1!");
                }

            }

            Console.WriteLine($"{topChef} won competition with {maxChefGrades} points!");


        }
    }
}
