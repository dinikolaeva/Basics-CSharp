using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double convertNum = double.Parse(Console.ReadLine());
            string enterUnit = Console.ReadLine();
            string exitUnit = Console.ReadLine();


            if (enterUnit == "mm" && exitUnit == "m")
            {
                double result = convertNum / 1000;
                Console.WriteLine($"{result:F3}");
            }
            else if (enterUnit == "mm" && exitUnit == "cm")
            {
                double result = convertNum / 10;
                Console.WriteLine($"{result:F3}");
            }
            else if (enterUnit == "m" && exitUnit == "cm")
            {
                double result = convertNum * 100;
                Console.WriteLine($"{result:F3}");
            }
            else if (enterUnit == "cm" && exitUnit == "mm")
            {
                double result = convertNum * 10;
                Console.WriteLine($"{result:F3}");
            }
            else if (enterUnit == "m" && exitUnit == "m")
            {
                double result = convertNum * 1;
                Console.WriteLine($"{result:f3}");
            }
            else if (enterUnit == "cm" && exitUnit == "m")
            {
                double result = convertNum / 100;
                Console.WriteLine($"{result:f3}");
            }
            else if (enterUnit == "m" && exitUnit == "mm")
            {
                double result = convertNum * 1000;
                Console.WriteLine($"{result:f3}");
            }
        }
    }
}
