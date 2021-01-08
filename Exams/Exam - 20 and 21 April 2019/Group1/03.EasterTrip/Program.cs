using System;
using System.Security.Cryptography;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalSum = 0;

            //      Дестинация      21 - 23 март     24 - 27 март      28 - 31 март
            //       Франция            30 лв.           35 лв.           40 лв.
            //       Италия             28 лв.           32 лв.           39 лв.
            //       Германия           32 лв.           37 лв.           43 лв.


            if (dates == "21-23")
            {
                if (destination == "France")
                {
                    totalSum = 30 * nights;
                }
                else if (destination == "Italy")
                {
                    totalSum = 28 * nights;
                }
                else if (destination == "Germany")
                {
                    totalSum = 32 * nights;
                }
            }
            else if (dates == "24-27")
            {
                if (destination == "France")
                {
                
                    totalSum = 35 * nights;

                }
                else if (destination == "Italy")
                {
                    totalSum = 32 * nights;
                }
                else if (destination == "Germany")
                {
                    totalSum = 37 * nights;
                }
            }
            else if (dates == "28-31")
            {
                if (destination == "France")
                {

                    totalSum = 40 * nights;

                }
                else if (destination == "Italy")
                {
                    totalSum = 39 * nights;
                }
                else if (destination == "Germany")
                {
                    totalSum = 43 * nights;
                }
            }

            Console.WriteLine($"Easter trip to {destination} : {totalSum:F2} leva.");
        }
    }
}
