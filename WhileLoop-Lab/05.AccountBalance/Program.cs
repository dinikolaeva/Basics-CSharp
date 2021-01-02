using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string payment = Console.ReadLine();

            double total = 0;

            while (payment != "NoMoreMoney")
            {

                if (payment != "NoMoreMoney" && double.Parse(payment) <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += double.Parse(payment);
                Console.WriteLine($"Increase: {double.Parse(payment):f2}");
                payment = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
