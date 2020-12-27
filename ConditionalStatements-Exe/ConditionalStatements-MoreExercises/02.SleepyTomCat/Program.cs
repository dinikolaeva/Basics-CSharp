using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            //	Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //	Когато почива, стопанинът му си играе с него по 127 минути на ден.


            int daysInYear = 365;
            int normPerYear = 30000;
            int whenWorks = 63;
            int notWorks = 127;

            int workingDaysPlayMinutes = (daysInYear - daysOff) * whenWorks;
            int hollidaysPlaiMinutes = daysOff * notWorks;
            int allPlayMinutes = workingDaysPlayMinutes + hollidaysPlaiMinutes;

            if (normPerYear < allPlayMinutes)
            {
                int normForPlay = allPlayMinutes - normPerYear;
                int hours = normForPlay / 60;
                int minutes = normForPlay % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int normForPlay = normPerYear - allPlayMinutes;
                int hours = normForPlay / 60;
                int minutes = normForPlay % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");


            }
        }
    }
}
