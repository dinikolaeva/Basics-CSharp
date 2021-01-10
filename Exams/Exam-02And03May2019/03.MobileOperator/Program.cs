using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string durationOfContract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string netExtra = Console.ReadLine();
            int countOfMonts = int.Parse(Console.ReadLine());

            double servicePrice = 0;
            double finalPrice = 0;

            switch (typeOfContract)
            {
                case "Small":
                    if (durationOfContract == "one")
                    {
                        servicePrice = 9.98;
                    }
                    else
                    {
                        servicePrice = 8.58;
                    }
                    break;

                case "Middle":
                    if (durationOfContract == "one")
                    {
                        servicePrice = 18.99;
                    }
                    else
                    {
                        servicePrice = 17.09;
                    }
                    break;
                case "Large":
                    if (durationOfContract == "one")
                    {
                        servicePrice = 25.98;
                    }
                    else
                    {
                        servicePrice = 23.59;
                    }
                    break;
                case "ExtraLarge":
                    if (durationOfContract == "one")
                    {
                        servicePrice = 35.99;
                    }
                    else
                    {
                        servicePrice = 31.79;
                    }
                    break;
            }

            if (netExtra == "yes")
            {
                if (servicePrice <= 10)
                {
                    servicePrice += 5.50;
                }
                else if (servicePrice <= 30)
                {
                    servicePrice += 4.35;
                }
                else
                {
                    servicePrice += 3.85;
                }
            }

            if (durationOfContract == "one")
            {
                finalPrice = servicePrice * countOfMonts;
                Console.WriteLine($"{finalPrice:f2} lv.");
            }
            else if (durationOfContract == "two")
            {
                finalPrice = servicePrice * countOfMonts;
                double twoYearsFinalPrice = finalPrice - (finalPrice * 0.0375);
                Console.WriteLine($"{twoYearsFinalPrice:f2} lv.");
            }
        }
    }
}
