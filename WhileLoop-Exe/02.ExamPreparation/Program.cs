using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBadGrades = int.Parse(Console.ReadLine());
            string nameOfTask = Console.ReadLine();

            bool isExellent = true;
            string lastProblem = "";
            int counter = 0;
            int badCount = 0;
            int score = 0;


            while (nameOfTask != "Enough")
            {
                lastProblem = nameOfTask;
                int grade = int.Parse(Console.ReadLine());
                counter++;
                score += grade;

                if (grade <= 4)
                {
                    badCount++;

                    if (badCount == countOfBadGrades)
                    {
                        isExellent = false;
                        break;
                    }
                }
                nameOfTask = Console.ReadLine();
            }

            if (isExellent)
            {
                double averageScore = 1.0 * score / counter;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {countOfBadGrades} poor grades.");
            }
        }

    }
}

