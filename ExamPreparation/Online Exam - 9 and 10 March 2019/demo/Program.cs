using System;

namespace _06.HighJump
{
    class Program
        {
            static void Main(string[] args)
            {
                int wishedHeight = int.Parse(Console.ReadLine());

                int jumpsSUCSESSCounter = 0; // връщам опитите до 0!
                int jumpsWithoutSUCSESSCounter = 0;
                int letvaHeight = wishedHeight - 30;

                int heightChageSum = wishedHeight;

                int jumpAgain = 0;


                while (true) //?!? heightChageSum >= letvaHeight - целта е първо да прескаме летвата, докато стигнем до желаното ниво!
                {
                    jumpAgain = int.Parse(Console.ReadLine());

                    jumpsSUCSESSCounter++;

                    //if (letvaHeight == heightChageSum) // първо трябва да сме сигурни, че е прескочена летвата успешно
                    //{
                    //    break;
                    //}

                    if (jumpAgain > letvaHeight) // тук е критичен момент в програмата - уверяваме се дали има успешен скок и ако е успешен дали нивото на летвата е стигнало желаната височина
                    {

                        if (letvaHeight >= heightChageSum) //jumpAgain >= heightChageSum
                        {
                            break;
                            //letvaHeight += 5; // това не е нужно
                            //jumpsWithoutSUCSESSCounter = 0;
                            //jumpsSUCSESSCounter++;
                            //continue;
                        }

                        letvaHeight += 5;
                        jumpsWithoutSUCSESSCounter = 0;

                    }
                    else if (jumpAgain <= letvaHeight)
                    {
                        jumpsWithoutSUCSESSCounter++;

                    }


                    if (jumpsWithoutSUCSESSCounter == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {letvaHeight}cm after {jumpsSUCSESSCounter} jumps.");
                        return;

                    }

                }

                Console.WriteLine($"Tihomir succeeded, he jumped over {letvaHeight}cm after {jumpsSUCSESSCounter} jumps.");

            }
        }
    }

