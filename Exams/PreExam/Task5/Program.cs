using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sleepOrNo = Console.ReadLine();
            int climbedMeters = int.Parse(Console.ReadLine());

            int countOfDays = 1;
            int allClimeMeters = 5364;

            while (sleepOrNo != "END")
            {

                if (sleepOrNo == "Yes")
                {

                    allClimeMeters += climbedMeters;
                    countOfDays++;
                }
                else
                {
                    allClimeMeters += climbedMeters;
                }

                if (allClimeMeters >= 8848 && countOfDays < 5)
                {
                    Console.WriteLine($"Goal reached for {countOfDays} days!");
                    break;
                }

                if (allClimeMeters < 8848 && countOfDays >= 5 || countOfDays >= 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{allClimeMeters}");
                    break;
                }

                sleepOrNo = Console.ReadLine();

                if (sleepOrNo == "END")
                {
                    break;
                }

                climbedMeters = int.Parse(Console.ReadLine());
            }

            if (sleepOrNo == "END")
            {

                if (allClimeMeters >= 8848 && countOfDays <= 5)
                {
                    Console.WriteLine($"Goal reached for {countOfDays} days!");
                }
                else if (allClimeMeters < 8848 && countOfDays > 5 || countOfDays >= 5 || allClimeMeters < 8848)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{allClimeMeters}");
                }

            }
        }
    }
}

