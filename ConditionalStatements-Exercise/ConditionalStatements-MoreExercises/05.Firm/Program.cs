using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            int workDayInHours = 8;
            double percentHours = days - (days * 0.10);
            double workHours = percentHours * workDayInHours;
            double overtimeHours = workers * (2 * days);
            double totalHours = workHours + overtimeHours;

            if (hours <= totalHours)
            {
                double leftTime = totalHours - hours;
                Console.WriteLine($"Yes!{Math.Floor(leftTime)} hours left.");
            }
            else
            {
                double leftTime = hours - totalHours;
                Console.WriteLine($"Not enough time!{Math.Ceiling(leftTime)} hours needed.");
            }


        }
    }
}
