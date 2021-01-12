using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double packOfPencils = 4.75;
            const double feltTipPens = 1.80;
            const double sketchbook = 6.50;
            const double notebooks = 2.50;

            int countOfPackOfPencils = int.Parse(Console.ReadLine());
            int countOfFeltTipPens = int.Parse(Console.ReadLine());
            int countOfSketchbooks = int.Parse(Console.ReadLine());
            int countOfNotebooks = int.Parse(Console.ReadLine());

            double pencilsPrice = packOfPencils * countOfPackOfPencils;
            double feltTipPensPrice = feltTipPens * countOfFeltTipPens;
            double sketchbooksPrice = sketchbook * countOfSketchbooks;
            double notebooksPrice = notebooks * countOfNotebooks;

            double totalSum = pencilsPrice + feltTipPensPrice + sketchbooksPrice + notebooksPrice;

            double finalTotal = totalSum - ((totalSum * 5) / 100);

            Console.WriteLine($"Your total is {finalTotal:f2}lv");
        }
    }
}
