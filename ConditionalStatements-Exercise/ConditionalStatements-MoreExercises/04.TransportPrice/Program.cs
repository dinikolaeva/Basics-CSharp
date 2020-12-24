using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            // Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            // Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            // Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.

            double taxyStartFee = 0.70;
            double taxiDayPrice = 0.79;
            double taxiNightPrice = 0.90;
            double busPrice = 0.09;
            double trainPrice = 0.06;

            if (n < 20 && text == "day")
            {
                double totalPrice = taxyStartFee + (taxiDayPrice * n);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (n < 20 && text == "night")
            {
                double totalPrice = taxyStartFee + (taxiNightPrice * n);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (n >= 20 && n < 100)
            {
                double totalPrice = busPrice * n;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (n >= 100)
            {
                double totalPrice = trainPrice * n;
                Console.WriteLine($"{totalPrice:F2}");
            }
        }
    }
}
