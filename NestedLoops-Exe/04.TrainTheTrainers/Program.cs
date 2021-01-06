using System;

namespace _4.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int membersOfJury = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();

            int countOfGrades = 0;
            double averageGradeSum = 0;
            double averageGrade = 0;
            double sumOfAllPresenation = 0;


            while (nameOfPresentation != "Finish")
            {

                for (int i = 0; i < membersOfJury; i++)
                {
                    double gradeForPresentation = double.Parse(Console.ReadLine());

                    countOfGrades++;
                    averageGradeSum += gradeForPresentation;
                    sumOfAllPresenation += gradeForPresentation;
                    averageGrade = averageGradeSum / membersOfJury;

                }

                Console.WriteLine($"{nameOfPresentation} - {averageGrade:f2}.");
                nameOfPresentation = Console.ReadLine();
                averageGradeSum = 0;
                averageGrade = 0;
            }

            double finalAssessment = sumOfAllPresenation / countOfGrades;
            Console.WriteLine($"Student's final assessment is {finalAssessment:f2}.");


        }
    }
}
