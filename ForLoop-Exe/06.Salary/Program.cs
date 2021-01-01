using System;

namespace _006.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Facebook = 150;
            const int Instagram = 100;
            const int Reddit = 50;

            int number = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                string browsers = Console.ReadLine();

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                if (browsers == "Facebook")
                {
                    salary -= Facebook;
                }
                else if (browsers == "Instagram")
                {
                    salary -= Instagram;
                }
                else if (browsers == "Reddit")
                {
                    salary -= Reddit;
                }
            }

            if (salary <= 0)
            {
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
