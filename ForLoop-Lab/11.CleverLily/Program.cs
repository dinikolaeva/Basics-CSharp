using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            double priceOfToys = double.Parse(Console.ReadLine());

            double savings = 0;
            double evenBirthday = 10;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += evenBirthday - 1;
                    evenBirthday += 10;
                }
                else
                {
                   toys++;
                }
            }

            double sumToys = toys * priceOfToys;
            double savedMoney = savings + sumToys;

            if (savedMoney >= priceOfWashingMachine)
            {
                double leftMoney = savedMoney - priceOfWashingMachine;
                Console.WriteLine($"Yes! {leftMoney:f2}");
            }
            else
            {
                double neededMoney = priceOfWashingMachine - savedMoney;
                Console.WriteLine($"No! {neededMoney:f2}");
            }
        }
    }
}
