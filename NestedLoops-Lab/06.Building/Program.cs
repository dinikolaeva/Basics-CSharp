using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floorsOfBuilding = floor; floorsOfBuilding >= 1; floorsOfBuilding--)
            {

                for (int roomsInBuilding = 0; roomsInBuilding < rooms; roomsInBuilding++)
                {

                    if (floor== floorsOfBuilding)
                    {
                        Console.Write($"L{floorsOfBuilding}{roomsInBuilding} ");
                    }
                    else if (floorsOfBuilding % 2 == 0)
                    {
                        Console.Write($"O{floorsOfBuilding}{roomsInBuilding} ");
                    }
                    else if (floorsOfBuilding % 2 !=0)
                    {
                        Console.Write($"A{floorsOfBuilding}{roomsInBuilding} ");
                    }
                }

                Console.WriteLine();
            }
        }
        }
    }
