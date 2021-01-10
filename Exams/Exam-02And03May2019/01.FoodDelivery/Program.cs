using System;

namespace _01.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {

            const double chickenMenu = 10.35;
            const double fishMenu = 12.40;
            const double vegiterianMenu = 8.15;
            const double delivery = 2.50;

            int countChickenMenu = int.Parse(Console.ReadLine());
            int countFishMenu = int.Parse(Console.ReadLine());
            int countVegiterianMenu = int.Parse(Console.ReadLine());

            double sumOfChicken = countChickenMenu * chickenMenu;
            double sumOfFish = countFishMenu * fishMenu;
            double sumOfVegi = countVegiterianMenu * vegiterianMenu;

            double fullSum = sumOfChicken + sumOfFish + sumOfVegi;

            double desertPrice = fullSum * 0.20;

            double totalSum = fullSum + desertPrice + delivery;

            Console.WriteLine($"Total: {totalSum:f2}");

        }
    }
}
