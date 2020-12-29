using System;
using System.Transactions;

namespace _005.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {

            double leightW = double.Parse(Console.ReadLine());
            double weightH = double.Parse(Console.ReadLine());

            double leightWSm = leightW * 100;
            double weightHSm = weightH * 100;

            double rows = Math.Floor(leightWSm / 120);
            double bearew = Math.Floor((weightHSm - 100) / 70);
            double seats = (rows * bearew) - 3;

            Console.WriteLine(seats);



        }
    }
}
