using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTickets = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int ticketPrice = int.Parse(Console.ReadLine());

            int sumOfAllTickets = ticketPrice * countOfTickets;

            if (sumOfAllTickets <= budget)
            {
                int change = budget - sumOfAllTickets;

                Console.WriteLine($"You can sell your client {countOfTickets} tickets for the price of {sumOfAllTickets}$!");
                Console.WriteLine($"Your client should become a change of {change}$!");
            }
            else
            {
                Console.WriteLine($"The budget of {budget}$ is not enough. Your client can't buy {countOfTickets} tickets with this budget!");
            }
        }
    }
}
