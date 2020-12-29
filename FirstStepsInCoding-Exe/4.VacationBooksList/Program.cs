using System;

namespace _04.Vacationbookslist
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesForHour = double.Parse(Console.ReadLine());
            double countDays = double.Parse(Console.ReadLine());
            double sumTime = pages / pagesForHour;
            double hourPerDay = sumTime / countDays;


            Console.WriteLine(hourPerDay);

        }
    }
}
