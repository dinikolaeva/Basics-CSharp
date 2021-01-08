using System;

namespace _01.Change_бюро
{
    class Program
    {
        static void Main(string[] args)
        {
            const double bitcoin = 1168.00;
            const double yuan = 0.15;
            const double dollar = 1.76;
            const double euro = 1.95;

            int countOfBitcoin = int.Parse(Console.ReadLine());
            double countOfYuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinInLeva = countOfBitcoin * bitcoin;
            double yuanInDollars = countOfYuan * yuan;
            double dollarsInLeva = yuanInDollars * dollar;
            double levaInEuro = (bitcoinInLeva + dollarsInLeva) / euro;
            double percentcommission = levaInEuro * (commission/100);
            double totalSum = levaInEuro - percentcommission;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
