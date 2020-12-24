using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            switch (town)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        double allPrice = count * 0.50;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "water")
                    {
                        double allPrice = count * 0.80;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "beer")
                    {
                        double allPrice = count * 1.20;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "sweets")
                    {
                        double allPrice = count * 1.45;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "peanuts")
                    {
                        double allPrice = count * 1.60;
                        Console.WriteLine(allPrice);
                    }
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        double allPrice = count * 0.40;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "water")
                    {
                        double allPrice = count * 0.70;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "beer")
                    {
                        double allPrice = count * 1.15;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "sweets")
                    {
                        double allPrice = count * 1.30;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "peanuts")
                    {
                        double allPrice = count * 1.50;
                        Console.WriteLine(allPrice);
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        double allPrice = count * 0.45;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "water")
                    {
                        double allPrice = count * 0.70;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "beer")
                    {
                        double allPrice = count * 1.10;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "sweets")
                    {
                        double allPrice = count * 1.35;
                        Console.WriteLine(allPrice);
                    }
                    else if (product == "peanuts")
                    {
                        double allPrice = count * 1.55;
                        Console.WriteLine(allPrice);
                    }
                    break;
            }

 
        }
    }
}
