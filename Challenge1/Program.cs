/*
 * Go to Challenge.cs and solve all the challenges before you check this file. You can run at any time. Only check after all the challenges has been completed.
 * 
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS































        NO.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace CodingChallenge
{
    internal partial class Program
    {
        static string[] WordList;
        static bool Passed = true;
        static bool Debug = true;

        static void FAILED(int index)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"Challenge {index}: ");
            Passed = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FAILED...");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void TEST(int index, bool failure)
        {
            if (failure) FAILED(index);
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"Challenge {index}: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            try
            {
                WordList = Challenge.Challenge1("wordlist.txt");
                TEST(1,
                    WordList == null ||
                    WordList.First() != "docty" ||
                    WordList.Last() != "zygal" ||
                    WordList.Length != 12484 ||
                    WordList.Select(s => s.Length).Distinct().Count() != 1 ||
                    WordList.Select(s => s.Length).Distinct().First() != 5
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                FAILED(1);
            }


            try
            {
                bool t2p1 = Challenge.Challenge2(null) != null ||
                            Challenge.Challenge2(new string[0]) != null ||
                            !(new string[] { "a", "b", "c", "d", "e" }.Contains(Challenge.Challenge2(new string[] { "a", "b", "c", "d", "e" })));
                bool t2p2w1 = false;
                bool t2p2w2 = false;
                int t2p2t = 100;
                while ((!t2p2w1 || !t2p2w1) && t2p2t > 0)
                {
                    string w = Challenge.Challenge2(new string[] { "a", "b", });
                    if (w == "a") t2p2w1 = true;
                    if (w == "b") t2p2w2 = true;
                    t2p2t--;
                }

                TEST(2, t2p1 || t2p2w1 || t2p2w2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                FAILED(2);
            }

            try
            {
                TEST(3,
                    Challenge.Challenge3(null, null) != null ||
                    Challenge.Challenge3(null, new string[0]) != null ||
                    Challenge.Challenge3("", null) != null ||
                    Challenge.Challenge3("asd", new string[0]) == InputValidation.Correct ||
                    Challenge.Challenge3("goodw", new string[1] { "goodw" }) != InputValidation.Correct ||
                    Challenge.Challenge3("wrongw", new string[1] { "wrongw" }) != InputValidation.InvalidLength
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                FAILED(3);
            }
            

            try
            {
                TEST(4,
                    Challenge.Challenge4('0', -1, null) != null ||
                    Challenge.Challenge4('a', -1, null) != null ||
                    Challenge.Challenge4('0', 1, null) != null ||
                    Challenge.Challenge4('0', -1, "") != null ||
                    Challenge.Challenge4('a', 0, "") != null ||
                    Challenge.Challenge4('a', 0, "b") != CharacterPosition.Wrong ||
                    Challenge.Challenge4('a', 0, "ba") != CharacterPosition.Misplaced ||
                    Challenge.Challenge4('a', 1, "ba") != CharacterPosition.Correct ||
                    Challenge.Challenge4('o', 2, "wrong") != CharacterPosition.Correct
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.ToString() );
                FAILED(4);
            }


            Console.WriteLine("Press any key to " + (Passed ? "continue" : "exit") + "...");
            Console.ReadKey();
            if (!Passed) return;

            /*
             
             Final program below.
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             */

            RESET:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome to Wordle...");
            Console.WriteLine("(Every word's length is 5)");
            Console.WriteLine("(Green character is in correct spot, yellow is misplaced, gray is not contained in word)");
            string word = Challenge.Challenge2(WordList);
            Console.WriteLine("A random word has been selected!");
            if (Debug) Console.WriteLine("Word: " + word);

            int tries = 0;
            while (tries < 5)
            {
                string input;
                while (true)
                {
                    Console.Write("Enter your guess: ");
                    input = Console.ReadLine().ToLower();
                    InputValidation? validity = Challenge.Challenge3(input, WordList) ?? throw new ArgumentNullException("WordList or UserInput is NULL");

                    switch (validity)
                    {
                        case InputValidation.NonExistent:
                            Console.WriteLine("Your word is not a word in the game's word collection.");
                            continue;
                        case InputValidation.InvalidLength:
                            Console.WriteLine("Your word's length is not 5.");
                            continue;
                        case InputValidation.Correct:
                            break;
                        default: break;
                    }
                    break;
                }

                bool correct = true;
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 0; i < input.Length; i++)
                {
                    CharacterPosition? cps = Challenge.Challenge4(input[i], i, word);
                    if (cps == CharacterPosition.Correct) Console.ForegroundColor = ConsoleColor.Green;
                    else correct = false;

                    if (cps == CharacterPosition.Misplaced) Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (cps == CharacterPosition.Wrong) Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(input[i]);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (correct) Console.WriteLine("You got it! Your word was: " + word);
                else
                {
                    tries++;
                    if (tries == 5)
                    {
                        Console.WriteLine("You Lost!");
                        goto RETRY_CONFIRMATION;
                    }
                    Console.WriteLine("Incorrect! Tries left: " + tries + "/5");
                    continue;
                }
                break;
            }

        RETRY_CONFIRMATION:
            Console.Write("Do you want to play again? (Y/N)");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y) goto RESET;
            if (key.Key == ConsoleKey.N) goto EXIT;
            else goto RETRY_CONFIRMATION;

            EXIT:
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        
    }
}
