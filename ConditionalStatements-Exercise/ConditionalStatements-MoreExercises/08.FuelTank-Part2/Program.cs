using System;
using System.Runtime.InteropServices;

namespace _08.FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeOfFuel = Console.ReadLine();
            double litresFuel = double.Parse(Console.ReadLine());
            string cardholder = Console.ReadLine();

            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            double gasolinePrice = gasoline * litresFuel;
            double dieselPrice = diesel * litresFuel;
            double gasPrice = gas * litresFuel;

            switch (cardholder)
            {
                case "Yes":
                    {
                        if (typeOfFuel == "Gasoline")
                        {
                            double gasolineDiscount = litresFuel * (gasoline - 0.18);
                            if (litresFuel > 20 && litresFuel <= 25)
                            {
                                double gasolinePlusPercentage = gasolineDiscount - (gasolineDiscount * 0.08);
                                Console.WriteLine($"{gasolinePlusPercentage:f2} lv.");
                            }
                            else if (litresFuel > 25)
                            {
                                double gasolinePlusPercentage = gasolineDiscount - (gasolineDiscount * 0.10);
                                Console.WriteLine($"{gasolinePlusPercentage:f2} lv.");
                            }
                            else if (litresFuel <= 20)
                            {
                                Console.WriteLine($"{gasolineDiscount:f2} lv.");
                            }
                        }
                        else if (typeOfFuel == "Diesel")
                        {
                            double dieselDiscount = litresFuel * (diesel - 0.12);
                            if (litresFuel > 20 && litresFuel <= 25)
                            {
                                double dieselPlusPercentage = dieselDiscount - (dieselDiscount * 0.08);
                                Console.WriteLine($"{dieselPlusPercentage:f2} lv.");
                            }
                            else if (litresFuel > 25)
                            {
                                double dieselPlusPercentage = dieselDiscount - (dieselDiscount * 0.10);
                                Console.WriteLine($"{dieselPlusPercentage:f2} lv.");
                            }
                            else if (litresFuel <= 20)
                            {
                                Console.WriteLine($"{dieselDiscount:f2} lv.");
                            }
                        }
                        else if (typeOfFuel == "Gas")
                        {
                            double gasDiscount = litresFuel * (gas - 0.08);
                            if (litresFuel > 20 && litresFuel <= 25)
                            {
                                double gasPlusPercentage = gasDiscount - (gasDiscount * 0.08);
                                Console.WriteLine($"{gasPlusPercentage:f2} lv.");
                            }
                            else if (litresFuel > 25)
                            {
                                double gasPlusPercentage = gasDiscount - (gasDiscount * 0.10);
                                Console.WriteLine($"{gasPlusPercentage:f2} lv.");
                            }
                            else if (litresFuel <= 20)
                            {
                                Console.WriteLine($"{gasDiscount:f2} lv.");
                            }
                        }
                    }
                    break;
                case "No":
                    {
                        if (typeOfFuel == "Gasoline" && litresFuel > 20 && litresFuel <= 25)
                        {
                            double gasolinePlusPercentage = litresFuel * (gasoline - (gasoline * 0.08));
                            Console.WriteLine($"{gasolinePlusPercentage:F2} lv.");
                        }
                        else if (typeOfFuel == "Gasoline" && litresFuel > 25)
                        {
                            double gasolinePlusPercentage = litresFuel * (gasoline - (gasoline * 0.10));
                            Console.WriteLine($"{gasolinePlusPercentage:F2} lv.");
                        }
                        else if (typeOfFuel == "Gasoline" && litresFuel <= 20)
                        {
                            Console.WriteLine($"{gasolinePrice:F2} lv.");
                        }
                        else if (typeOfFuel == "Diesel" && litresFuel > 20 && litresFuel <= 25)
                        {
                            double dieselPlusPercentage = litresFuel * (diesel - (diesel * 0.08));
                            Console.WriteLine($"{dieselPlusPercentage:f2} lv.");
                        }
                        else if (typeOfFuel == "Diesel" && litresFuel > 25)
                        {
                            double dieselPlusPercentage = litresFuel * (diesel - (diesel * 0.10));
                            Console.WriteLine($"{dieselPlusPercentage:f2} lv.");
                        }
                        else if (typeOfFuel == "Diesel" && litresFuel <= 20)
                        {
                            Console.WriteLine($"{dieselPrice:F2} lv.");
                        }
                        else if (typeOfFuel == "Gas" && litresFuel >20 && litresFuel <= 25)
                        {
                            double gasPlusPercentage = litresFuel * (gas - (gas * 0.08));
                            Console.WriteLine($"{gasPlusPercentage:f2} lv.");
                        }
                        else if (typeOfFuel == "Gas" && litresFuel > 25)
                        {
                            double gasPlusPercentage = litresFuel * (gas - (gas * 0.10));
                            Console.WriteLine($"{gasPlusPercentage:f2} lv.");
                        }
                        else if (typeOfFuel == "Gas" && litresFuel <= 20)
                        {
                            Console.WriteLine($"{gasPrice:F2} lv.");
                        }
                            break;
                    }
            }
        }
    }
}
