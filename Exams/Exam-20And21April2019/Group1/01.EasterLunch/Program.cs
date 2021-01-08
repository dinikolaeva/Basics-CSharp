using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            const double easterBread = 3.20;
            const double eggs = 4.35;
            const double cookies = 5.40;
            const double paintForEggs = 0.15 * 12;

            int countOfEasterBread = int.Parse(Console.ReadLine());
            int dozenOfEggs = int.Parse(Console.ReadLine());
            int cookiesKilos = int.Parse(Console.ReadLine());

            double sumOfEasterBread = countOfEasterBread * easterBread;
            double sumOfEggs = dozenOfEggs * eggs;
            double sumOfCookies = cookiesKilos * cookies;
            double sumWithPaint = dozenOfEggs * paintForEggs;

            double totalSum = sumOfCookies + sumOfEasterBread + sumOfEggs + sumWithPaint;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
