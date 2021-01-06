using System;

namespace _01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double annualFee = double.Parse(Console.ReadLine());

            double sneakersPrice = annualFee - (annualFee * 0.40);
            double equpmentPrice = sneakersPrice - (sneakersPrice * 0.20);
            double basketball = equpmentPrice / 4;
            double accessoires = basketball / 5;

            double totalSum = annualFee + sneakersPrice + equpmentPrice + basketball + accessoires;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
