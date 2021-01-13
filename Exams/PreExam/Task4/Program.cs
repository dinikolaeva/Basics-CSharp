using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double investMoney = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double simpleInterestRate = 0;
            double simpleSum = investMoney;
            double complexInterestRate = 0;
            double complexSum = investMoney;
            double winSum = 0;

            for (int i = 1; i <= months; i++)
            {
                simpleInterestRate = simpleSum + (investMoney * 0.03);
                simpleSum = simpleInterestRate;
                complexInterestRate = complexSum + (complexSum * 0.027);
                complexSum = complexInterestRate;

            }

            Console.WriteLine($"Simple interest rate: {simpleSum:f2} lv. ");
            Console.WriteLine($"Complex interest rate: {complexSum:f2} lv.");

            if (simpleSum > complexSum)
            {
                winSum = simpleSum - complexSum;
                Console.WriteLine($"Choose a simple interest rate. You will win {winSum:f2} lv.");
            }
            else
            {
                winSum = complexSum - simpleSum;
                Console.WriteLine($"Choose a complex interest rate. You will win {winSum:f2} lv.");
            }
        }
    }
}
