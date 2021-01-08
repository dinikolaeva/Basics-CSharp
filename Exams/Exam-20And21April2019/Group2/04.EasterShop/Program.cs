using System;

namespace _4.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int startCountOfEggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int countOfSoldEggs = 0;

            while (command != "Close")
            {
                int countOfEggsBuyOrFill = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {

                    if (countOfEggsBuyOrFill > startCountOfEggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {startCountOfEggs}.");
                        break;
                    }

                    startCountOfEggs -= countOfEggsBuyOrFill;
                    countOfSoldEggs += countOfEggsBuyOrFill;
                }
                else
                {
                    startCountOfEggs += countOfEggsBuyOrFill;
                }

                command = Console.ReadLine();                
            }

            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{countOfSoldEggs} eggs sold.");
            }
         
        }
    }
}
