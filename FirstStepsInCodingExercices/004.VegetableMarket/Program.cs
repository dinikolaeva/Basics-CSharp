using System;

namespace _004.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double courseEuro = 1.94;

            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            double allKgVegetables = double.Parse(Console.ReadLine());
            double allKgFruits = double.Parse(Console.ReadLine());

            double vegetablesValue = vegetablesPrice * allKgVegetables;
            double fruitsValue = fruitsPrice * allKgFruits;
            double allSumLv = vegetablesValue + fruitsValue;
            double allSumEuro = allSumLv / 1.94;


            Console.WriteLine($"{allSumEuro:F2}");
        }
    }
}
