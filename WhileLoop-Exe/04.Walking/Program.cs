using System;

namespace _4.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int target = 10000;

            string steps = Console.ReadLine();
            int sumOfSteps = 0;
            int deff = 0;

            while (steps != "Going home")
            {

                int stepsToGo = int.Parse(steps);
                sumOfSteps += stepsToGo;

                if (sumOfSteps >= target)
                {
                    deff = sumOfSteps - target;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{deff} steps over the goal!");
                    break;
                }

                steps = Console.ReadLine();
            }

            if (steps == "Going home")
            {
                steps = Console.ReadLine();
                int stepsToGo = int.Parse(steps);
                sumOfSteps += stepsToGo;

                if (sumOfSteps < target)
                {
                    deff = target - sumOfSteps;
                    Console.WriteLine($"{deff} more steps to reach goal.");
                }
                else if (sumOfSteps >= target)
                {
                    deff = sumOfSteps - target;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{deff} steps over the goal!");
                }
            }
            
        }
    }
}
