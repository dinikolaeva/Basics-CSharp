using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentForHall = double.Parse(Console.ReadLine());
            double cake = rentForHall * 0.20;
            double drink = cake - (cake * 0.45);
            double animator = rentForHall / 3;
            double totalSum = rentForHall + cake + drink + animator;

            Console.WriteLine(totalSum);

        }
    }
}
