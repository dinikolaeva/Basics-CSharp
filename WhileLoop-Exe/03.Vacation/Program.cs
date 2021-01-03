using System;
using System.Threading;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationMoney = double.Parse(Console.ReadLine());
            double moneySheHad = double.Parse(Console.ReadLine());

            int days = 0;
            int spendCounter = 0;

            while (moneySheHad < vacationMoney)
            {
                days++;
                string savedOrSpended = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (savedOrSpended == "save")
                {
                    spendCounter = 0;
                    moneySheHad += money;
                }

                else if (savedOrSpended == "spend")
                {
                    spendCounter++;

                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }

                    moneySheHad -= money;

                    if (moneySheHad < 0)
                    {
                        moneySheHad = 0;
                    }
                }
            }

            if (moneySheHad >= vacationMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
