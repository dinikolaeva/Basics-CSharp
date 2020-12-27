using System;
using System.Reflection.Metadata;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int oters = int.Parse(Console.ReadLine());
            double foodDogs = dogs * 2.50;
            double foodOters = oters * 4.00;
            double finalAmaunt = foodDogs + foodOters;

            Console.WriteLine($"{finalAmaunt} lv.");
        }
    }
}
