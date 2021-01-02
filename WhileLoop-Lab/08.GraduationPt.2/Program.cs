using System;
using System.Security.Claims;

namespace _08.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int currentClass = 1;
            double averageGrade = 0;
            double sumOfGrade = 0;
            int counter = 0;

            while (currentClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    currentClass++;
                    sumOfGrade += grade;
                }
                else
                {
                    counter++;
                }

                if (counter > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {currentClass} grade");
                    break;
                }
            }

            if (counter<2)
            {
                averageGrade = sumOfGrade / 12;

                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
