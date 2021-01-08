using System;

namespace _3.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (size == "small")
                    {
                        price = 2 * 56.00;
                    }
                    else
                    {
                        price = 5 * 28.70;
                    }
                    break;
                case "Mango":
                    if (size == "small")
                    {
                        price = 2 * 36.66;
                    }
                    else
                    {
                        price = 5 * 19.60;
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        price = 2 * 42.10;
                    }
                    else
                    {
                        price = 5 * 24.80;
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        price = 2 * 20.00;
                    }
                    else
                    {
                        price = 5 * 15.20;
                    }
                    break;
            }

            totalPrice = sets * price;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (totalPrice > 1000)
            {
                totalPrice -= totalPrice * 0.50;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
