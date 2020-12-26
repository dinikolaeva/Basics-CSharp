using System;
using System.Runtime.Serialization.Formatters;

namespace _001.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i%10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
