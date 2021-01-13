using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countOfHours = int.Parse(Console.ReadLine());
            int countOfPeoplesInGroup = int.Parse(Console.ReadLine());
            string timeOfDayNight = Console.ReadLine();

            double priceForOnePerson = 0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    if (timeOfDayNight == "day")
                    {
                        priceForOnePerson = 10.50;
                    }
                    else
                    {
                        priceForOnePerson = 8.40;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    if (timeOfDayNight == "day")
                    {
                        priceForOnePerson = 12.60;
                    }
                    else
                    {
                        priceForOnePerson = 10.20;
                    }
                    break;
                default:
                    break;
            }

            if (countOfPeoplesInGroup >= 4)
            {
                priceForOnePerson -= priceForOnePerson * 0.10;
            }

            if (countOfHours >= 5)
            {
                priceForOnePerson -= priceForOnePerson * 0.50;
            }

            double totoalSum = (priceForOnePerson * countOfPeoplesInGroup) * countOfHours;

            Console.WriteLine($"Price per person for one hour: {priceForOnePerson:f2}");
            Console.WriteLine($"Total cost of the visit: {totoalSum:f2}");
        }
    }
}
