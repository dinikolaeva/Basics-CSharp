using System;

namespace _006.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {

            //Паламуд – 60% по-скъп от скумрията
            //Сафрид – 80 % по - скъп от цацата
            //Миди – 7.50 лв.за килограм


            double mackerelPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double horseMackerelKg = double.Parse(Console.ReadLine());
            double musselsKg = double.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice + (mackerelPrice * 0.60);
            double horseMackerelPrice = toyPrice + (toyPrice * 0.80);
            double musselsPrice = 7.50;
            double sumBonito = bonitoPrice * bonitoKg;
            double sumHorseMackerel = horseMackerelKg * horseMackerelPrice;
            double sumMussels = musselsKg * musselsPrice;
       
            double total = sumBonito + sumHorseMackerel + sumMussels;

            Console.WriteLine($"{total:F2}");

        }
    }
}
