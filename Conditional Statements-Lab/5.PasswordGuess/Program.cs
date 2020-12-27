using System;

namespace _05.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            if (pass == "s3cr3t!P@ssw0rd")

            {
                Console.WriteLine("Welcome");
            }

            else if (pass != "s3cr3t!P@ssw0rd")

            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
