using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;

namespace _01._3StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isLetterC = false;
            int countC = 0;
            int sumC = 0;
            bool isLetterO = false;
            int countO = 0;
            int sumO = 0;
            bool isLetterN = false;
            int countN = 0;
            int sumN = 0;
            string word = "";
            string mainWord = "";
            char currentLetter;
            bool IsEnglishLetter = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else
                {

                    if (Char.IsLetter(char.Parse(input)))
                    {
                        currentLetter = char.Parse(input);

                        if (currentLetter == 'c')
                        {
                            countC++;
                            sumC += countC;

                            if (countC > 1)
                            {
                                word += currentLetter;
                            }
                            else
                            {
                                isLetterC = true;
                            }

                        }
                        if (currentLetter == 'o')
                        {
                            countO++;
                            sumO += countO;

                            if (countO > 1)
                            {
                                word += currentLetter;
                            }
                            else
                            {
                                isLetterO = true;
                            }

                        }
                        if (currentLetter == 'n')
                        {
                            countN++;
                            sumN += countN;

                            if (countN > 1)
                            {
                                word += currentLetter;
                            }
                            else
                            {
                                isLetterN = true;
                            }

                        }

                        if (currentLetter != 'c' && currentLetter != 'o' && currentLetter != 'n')
                        {
                            word += currentLetter;
                        }

                        if (sumC >= 1 && sumO >= 1 && sumN >= 1)
                        {

                            mainWord += word + " ";
                            word = "";
                            sumC = 0;
                            sumO = 0;
                            sumN = 0;
                            isLetterC = false;
                            isLetterN = false;
                            isLetterO = false;
                            countC = 0;
                            countO = 0;
                            countN = 0;
                        }

                        input = Console.ReadLine();
                    }
                }
            }

                Console.WriteLine(mainWord);
        }
    }
}
