using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();

            int studentTicket = 0;
            int standartTicket = 0;
            int kidTicket = 0;

            int totalPurchasedTickets = 0;
            int ticketCount = 0;

            while (filmName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                string typeOfTicket = Console.ReadLine();

                while (typeOfTicket != "End")
                {
                    totalPurchasedTickets++;
                    ticketCount++;

                    if (typeOfTicket == "student")
                    {
                        studentTicket++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standartTicket++;
                    }
                    else
                    {
                        kidTicket++;
                    }

                    if (ticketCount == freeSeats)
                    {
                        break;
                    }

                    typeOfTicket = Console.ReadLine();
                }

                

                double percentFullHall = ticketCount * 1.0 / freeSeats * 100;

                Console.WriteLine($"{filmName} - {percentFullHall:f2}% full.");


                filmName = Console.ReadLine();
                ticketCount = 0;
            }

            double percentStudentTickets = studentTicket * 1.0 / totalPurchasedTickets * 100;
            double percentStandardTickets = standartTicket * 1.0 / totalPurchasedTickets * 100;
            double percentKidTickets = kidTicket * 1.0 / totalPurchasedTickets * 100;

            Console.WriteLine($"Total tickets: {totalPurchasedTickets}");
            Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");
        }
    }
}
