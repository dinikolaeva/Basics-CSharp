using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int periodPerMount = int.Parse(Console.ReadLine());
            double PorcentYear = double.Parse(Console.ReadLine());
            double interestAmount = (deposit * PorcentYear) / 100;
            double oneMountPorcent = interestAmount / 12;
            //общата сума е 200лв депозит + (3 (срок на депозита) * 0.95 лв)
            double allSum = deposit + (periodPerMount * oneMountPorcent);

            Console.WriteLine(allSum);

        }
    }
}
