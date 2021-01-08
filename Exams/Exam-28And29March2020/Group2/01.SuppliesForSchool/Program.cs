using System;

namespace _01.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            const double packetOfPen = 5.80;
            const double packetOfMarkers = 7.20;
            const double cleaner = 1.20;

            int countOfPen = int.Parse(Console.ReadLine());
            int countOfMarkers = int.Parse(Console.ReadLine());
            double litresOfCleaner = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double penPrice = countOfPen * packetOfPen;
            double markersPrice = countOfMarkers * packetOfMarkers;
            double cleanerPrice = litresOfCleaner * cleaner;
            double allPrice = penPrice + markersPrice + cleanerPrice;
            double percentForAll = allPrice * percent / 100;
            double priceWithDiscount = allPrice - percentForAll;

            Console.WriteLine($"{priceWithDiscount:f3}");
        }
    }
}
