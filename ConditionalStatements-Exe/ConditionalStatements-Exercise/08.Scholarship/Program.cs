using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = minimalSalary * 0.35;
            double excelentScholarship = averageSuccess * 25.00;
            //Изискване за социална стипендия - 
            //доход на член от семейството по-малък от минималната работна заплата и успех над 4.5.
            //Изискване за стипендия за отличен успех -успех над 5.5, включително.

            if (income < minimalSalary && averageSuccess > 5.50 && socialScholarship > excelentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if(income < minimalSalary && averageSuccess > 5.50 && socialScholarship < excelentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excelentScholarship)} BGN");
            }
            else if (averageSuccess >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excelentScholarship)} BGN");
            }
            else if (income < minimalSalary && averageSuccess > 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excelentScholarship)} BGN");
            }
            else if (income < minimalSalary && averageSuccess >= 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (income > minimalSalary && averageSuccess < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income > minimalSalary && averageSuccess < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalSalary && averageSuccess < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
