using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string reating = Console.ReadLine();

            double priceWithDiscount = 0;
            double nights = days - 1;

            switch (typeOfRoom) 
            {
                case "room for one person":
                    priceWithDiscount = nights * 18.00;
                    break;
                case "apartment":
                    priceWithDiscount = nights * 25.00;
                    if (nights <= 10)
                    {
                        priceWithDiscount -= priceWithDiscount * 0.30;
                    }
                    else if (nights>10 && nights <= 15)
                    {
                        priceWithDiscount -= priceWithDiscount * 0.35;
                    }
                    else if (nights > 15)
                    {
                        priceWithDiscount -= priceWithDiscount * 0.50;
                    }
                    break;
                case "president apartment":
                    priceWithDiscount = nights * 35.00;
                    if (nights <= 10)
                    {
                        priceWithDiscount -= priceWithDiscount * 0.10;
                    }
                    else if (nights > 10 && nights <= 15)
                    {
                        priceWithDiscount -= priceWithDiscount * 0.15;
                    }
                    else if (nights > 15)
                    {
                        priceWithDiscount -= priceWithDiscount * 0.20;
                    }
                    break;

            }
            switch (reating)
            {
                case "positive":
                    priceWithDiscount += priceWithDiscount * 0.25;
                    Console.WriteLine($"{priceWithDiscount:f2}");
                    break;
                case"negative":
                    priceWithDiscount -= priceWithDiscount * 0.10;
                    Console.WriteLine($"{priceWithDiscount:f2}");
                    break;
            }
        }
    }
}
