using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clove__Command_Line_ {
    public class NumberGuess {
        public void NumberGuessGame() {

            //variables for number guess game
            string input;
            int numOfRounds;
            int guess;
            Random number = new Random();
            double correctNumber;
            string chosenDifficulty;
            int difficulty = 0;
            int score = 0;
            string roundLength;

            Console.WriteLine("\n\t\t\t ▒▒▒░░░▒▒▒░░░░▒▒▒░░░▒▒▒");
            Console.WriteLine("\t\t\t ░░░                ░░░");
            Console.WriteLine("\t\t\t ▒▒▒  Number Guess  ▒▒▒");
            Console.WriteLine("\t\t\t ░░░                ░░░");
            Console.WriteLine("\t\t\t ▒▒▒░░░▒▒▒░░░░▒▒▒░░░▒▒▒");
            Console.WriteLine("\t\t\t\t    \n");
            Thread.Sleep(500);
            while (true) {
                Console.WriteLine("\n\t How many rounds would you like to play:\n");
                input = Console.ReadLine();
                if (int.TryParse(input, out numOfRounds)) {
                    if (numOfRounds > 0 && numOfRounds < 11) {
                        break;
                    } else {
                        Console.WriteLine("\t Maximum number of rounds is 10...\n");
                    }
                } else {
                    Console.WriteLine("\t Please enter a number over 0...\n");
                    Thread.Sleep(500);
                }
            }

            //difficulty seleciton
            Thread.Sleep(200);
            Console.WriteLine("\t Choose a difficulty: easy | normal | hard\n");
            while (true) {
                chosenDifficulty = Console.ReadLine();
                switch (chosenDifficulty) {
                    case "easy":
                        difficulty = 4;
                        break;
                    case "normal":
                        difficulty = 2;
                        break;
                    case "hard":
                        difficulty = 0;
                        break;
                    default:
                        Console.WriteLine("\t Please choose a valid difficulty...\n");
                        break;
                }
                if (chosenDifficulty == "easy" || chosenDifficulty == "normal" || chosenDifficulty == "hard") {
                    break;
                }
            }
            Thread.Sleep(500);
            Console.WriteLine("\n");
            for (int i = 1; i <= numOfRounds; i++) {

                //round length UI box correction
                roundLength = i.ToString();
                if (roundLength.Length == 2) {
                    Console.Clear();
                    Console.WriteLine("\n\t\t\t ▓▓▓▒▒▒▒▓▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒            ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓  Round " + i + "  ▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒            ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓▒▒▒▒▓▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t\t    \n");
                    Thread.Sleep(500);
                } else {
                    Console.Clear();
                    Console.WriteLine("\n\t\t\t ▓▓▓▒▒▒▒▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒           ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓  Round " + i + "  ▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒           ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓▒▒▒▒▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t\t    \n");
                    Thread.Sleep(500);
                }
                //game

                correctNumber = number.Next(1, 10);
                Console.WriteLine("\t Guess a number between 1 - 10:\n");

                //user can guess for a number of times according to difficulty chosen before
                for (int trys = difficulty; trys >= 0; trys--) {
                    while (true) {
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (int.TryParse(input, out guess)) {
                            Thread.Sleep(200);
                            break;
                        } else {
                            Thread.Sleep(200);
                            Console.WriteLine("\t Please enter a number...\n");
                            Thread.Sleep(500);
                        }
                    }

                    //round finished sequence
                    if (guess == correctNumber) {
                        Thread.Sleep(200);
                        Console.WriteLine("\t Well done, answer was " + correctNumber + "\n");
                        score++;
                        Thread.Sleep(200);
                        break;
                    } else {
                        Thread.Sleep(200);
                        Console.WriteLine("\t Wrong! Try again...\n");
                        Thread.Sleep(500);
                        Console.WriteLine("\t You have " + trys + " trys left... \n");
                        Thread.Sleep(200);
                    }
                }
                Console.WriteLine("\n\t Press Enter to go to next round...\n");
                Console.ReadLine();
            }

            //game finished sequence
            Thread.Sleep(200);
            if (score > 0) {
                Console.WriteLine("\t You got " + score + " guesses correct!\n");
                Console.WriteLine("\t Press Enter to go back to the menu...\n");
                Console.ReadLine();
            } else {
                Console.WriteLine("\t You got " + score + " guesses correct, better luck next time...\n");
                Console.WriteLine("\t Press Enter to go back to the menu...\n");
                Console.ReadLine();
            }
        }
    }
}
