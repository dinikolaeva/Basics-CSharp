using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGroups = int.Parse(Console.ReadLine());

            int musala = 0;
            int montblanc = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            int allPeople = 0;

            for (int i = 1; i <= countOfGroups; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    musala += people;
                }
                else if (people > 5 && people <= 12)
                {
                    montblanc += people;
                }
                else if (people > 12 && people <= 25)
                {
                    kilimandjaro += people;
                }
                else if (people > 25 && people <= 40)
                {
                    k2 += people;
                }
                else
                {
                    everest += people;
                }

                allPeople += people;
            }

            double percentMusala = musala * 1.0 / allPeople * 100;
            double percentMontblanc = montblanc * 1.0 / allPeople * 100;
            double percentKilimandjaro = kilimandjaro * 1.0 / allPeople * 100;
            double percentK2 = k2 * 1.0 / allPeople * 100;
            double percentEverest = everest * 1.0 / allPeople * 100;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMontblanc:f2}%");
            Console.WriteLine($"{percentKilimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
