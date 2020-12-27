using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothes = statists * clothesPrice;


            if (statists >= 150)
            {
                clothes *= 0.90;
            }

            double totalPrice = decor + clothes;

            if (totalPrice <= budget)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
        }
    }
}
