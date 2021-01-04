using System;


namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {

                double budget = double.Parse(Console.ReadLine());
                double savedMoney = double.Parse(Console.ReadLine());

                double sumForTravelling = 0;

                while (sumForTravelling < budget)
                {

                    sumForTravelling += savedMoney;

                    if (sumForTravelling >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }

                    savedMoney = double.Parse(Console.ReadLine());
                }

                destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

            }

        }
    }
}
