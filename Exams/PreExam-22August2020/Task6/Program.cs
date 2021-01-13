using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int validCount = 0;
            int count = 0;

            for (int i = k; i <= 8; i++)
            {
                for (int o = 9; o >= l; o--)
                {
                    for (int p = m; p <= 8; p++)
                    {
                        for (int r = 9; r >= n; r--)
                        {
                            if (i % 2 == 0 && o % 2 != 0 && p % 2 == 0 && r % 2 != 0)
                            {

                                if (i == p && o == r)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{i}{o} - {p}{r}");
                                    count++;
                                }

                                if (count == 6)
                                {
                                    return;
                                }

                            }

                          
                        }
                        
                    }
                    
                }
                
            }
        }
    }
}
