using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfBook = Console.ReadLine();
            string input = Console.ReadLine();
            bool isFound = false;
            int counter = 0;

            while (input != "No More Books")
            {
                if (nameOfBook == input)
                {
                    isFound = true;
                    break;
                }

                counter++;
                input = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
