using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;

namespace Hangman
{
    class Program
    {

        // use this for when the string is bigger than size 1
        public static int inputWordAtt(string input, string currentWord, int numberOfAttempts)
        {
            if (input == currentWord)
            {
                Console.WriteLine("You are correct! Word is {0}", currentWord);
                return numberOfAttempts;
            }
            else
            {
                numberOfAttempts++;
                Console.WriteLine("You are incorrect! {0} attempts remaining", 6 - numberOfAttempts);
                return numberOfAttempts;
            }
        }

        // use this for when the input is exactly size 1
        public static int inputCharAtt(char input, string currentWord, int numberOfAttempts)
        {
            if (currentWord.Contains(input))
            {
                return numberOfAttempts;
            }
            else
            {
                numberOfAttempts++;
                Console.WriteLine("You are incorrect! {0} attempts remaining", 6 - numberOfAttempts);
                return numberOfAttempts;
            }
        }


        // method for when the character is in the word
        public static string inputCharContains(char input, string currentWord, string underscore)
        {
            if (currentWord.Contains(input))
            {
                int i = 0;
                foreach (char c in currentWord)
                {

                    if (c == input)
                    {
                        char[] underChar = underscore.ToCharArray();
                        underChar[currentWord.IndexOf(input, i)] = input;
                        string mediator = new string(underChar);
                        underscore = mediator;

                    }
                    i++;
                }
                //Console.WriteLine(underscore);
                return underscore;
            }
            else
            {
                return underscore;
            }

        }







        // luke - trying to take input char[] and current word char[] and checks for matches
        public static ArrayList charCheck(char[] input, char[] currentWord)
        {
            ArrayList indexes = new ArrayList();
            foreach (char c in currentWord)
            {
                if (c == input[0])
                {
                    indexes.Add(c);
                }
            }
            return indexes;

            //returns arraylist with indexes where they match else returns empty arraylist, check .isEmpty()
        }


        // method to print the man
        public static void figureBuilder(int n)
        {
            int incorrectAttemptCounter = n;

            switch (incorrectAttemptCounter)
            {
                case 1:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 2:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 3:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 4:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 5:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 6:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("           / \\      |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                default:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
            }
        }


        static void Main(string[] args)
        {

            // pick random word from list
            Random random = new Random();
            WebClient wc = new WebClient();
            string wordlist = wc.DownloadString("https://raw.githubusercontent.com/dwyl/english-words/master/words_alpha.txt");
            //string[] split = System.IO.File.ReadAllLines(@"C:\Users\Jesse\Desktop\Capita\VisualStudio2019\Git\Hangman\words_alpha.txt");
            string [] split = wordlist.Split('\n'); 
            split = split.Select(s => s.ToUpperInvariant()).ToArray();
            string rdmWord = split[random.Next(0, split.Length - 1)];
            Console.WriteLine(rdmWord);


            // underscore string
            string underscore = "";
            for (int i = 0; i < rdmWord.Length; i++)
            {
                underscore = underscore + "_";
            }
            Console.WriteLine(underscore);
            Console.WriteLine("This is a {0}-letter word", underscore.Length);


            // prints a hangman
            int incorrectAttempts = 0;
            figureBuilder(incorrectAttempts);



            // while loop
            while (incorrectAttempts < 6)
            {
                // take input and put into a character array
                Console.WriteLine("Please enter a letter as your guess");
                String inputString = Console.ReadLine();
                inputString = inputString.ToUpper();
                char inputChar = new char();
                if (inputString.Length == 1)
                {
                    char[] stringArray = inputString.ToCharArray();
                    inputChar = stringArray[0];
                    Console.WriteLine("you entered one letter: {0}", inputChar);
                    incorrectAttempts = inputCharAtt(inputChar, rdmWord, incorrectAttempts);
                    figureBuilder(incorrectAttempts);

                    // test area
                    underscore = inputCharContains(inputChar, rdmWord, underscore);
                    if (underscore == rdmWord)
                    {
                        Console.WriteLine("Congratulations! The word was: {0}", rdmWord);
                        goto End;
                    }
                    if (incorrectAttempts == 6)
                    {
                        Console.WriteLine("You have lost! The word was: {0}", rdmWord);
                    }
                    else
                    {
                        Console.WriteLine(underscore);
                    }



                }
                else
                {
                    Console.WriteLine("kept as string: {0}", inputString);

                    int tracker = inputWordAtt(inputString, rdmWord, incorrectAttempts);
                    if (incorrectAttempts == tracker)
                    {
                        figureBuilder(incorrectAttempts);
                        goto End;
                    }

                    incorrectAttempts = tracker;
                    figureBuilder(incorrectAttempts);
                }


            }

        End:
            Console.ReadLine();


        }
    }
}