using System;

namespace _01._6Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string fullPhrase = "";
            string word = "";
            bool specialN = false;
            bool specialO = false;
            bool specialC = false;
            char currentLetter;


            while (true)
            {
                input = Console.ReadLine();
                if (input != "End")
                {
                    if (Char.IsLetter(char.Parse(input)))
                    {
                        currentLetter = char.Parse(input);

                        if ((currentLetter == 'n' && specialN == true) ||
                            (currentLetter == 'o' && specialO == true) ||
                            (currentLetter == 'c' && specialC == true))
                        {
                            fullPhrase = fullPhrase + currentLetter;
                        }

                        if (currentLetter == 'n' && specialN == false)
                        {
                            // special character, skip letter
                            specialN = true;
                        }

                        if (currentLetter == 'o' && specialO == false)
                        {
                            // special character, skip letter
                            specialO = true;
                        }

                        if (currentLetter == 'c' && specialC == false)
                        {
                            // special character, skip letter
                            specialC = true;
                        }


                        if (currentLetter != 'n' && currentLetter != 'o' && currentLetter != 'c')
                        {
                            fullPhrase = fullPhrase + currentLetter;
                        }

                        if (specialN == true && specialO == true && specialC == true)
                        {
                            word = word + fullPhrase + " ";
                            fullPhrase = "";

                            specialC = false;
                            specialN = false;
                            specialO = false;
                        }


                    }
                }
                else
                {
                    break;
                }



            }
            Console.WriteLine(word);
        }
    }
}
