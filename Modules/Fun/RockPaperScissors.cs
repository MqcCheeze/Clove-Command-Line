using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clove__Command_Line_ {
    public class RockPaperScissors {

        public void RockPaperScissorsGame() {

            //variables for RPS
            string choice;
            Random cpuChoiceRdm = new Random();
            int cpuChoice;
            string cpuChoiceStr;

            Console.WriteLine("\n\t\t\t ▒▒▒░░░▒▒▒░░░░▒▒▒░░░░▒▒▒░░░▒▒▒");
            Console.WriteLine("\t\t\t ░░░                       ░░░");
            Console.WriteLine("\t\t\t ▒▒▒  Rock Paper scissors  ▒▒▒");
            Console.WriteLine("\t\t\t ░░░                       ░░░");
            Console.WriteLine("\t\t\t ▒▒▒░░░▒▒▒░░░░▒▒▒░░░░▒▒▒░░░▒▒▒");
            Console.WriteLine("\n");
            Thread.Sleep(500);

            //user selection
            Console.WriteLine("\t Choose an option: rock | paper | sissors\n");
            while (true) {
                choice = Console.ReadLine();

                cpuChoice = cpuChoiceRdm.Next(0, 2);
                if (cpuChoice == 0) {
                    cpuChoiceStr = "rock";
                } else if (cpuChoice == 1) {
                    cpuChoiceStr = "paper";
                } else {
                    cpuChoiceStr = "scissors";
                }

                //if statements to see who's won
                if (choice == cpuChoiceStr) {
                    Console.WriteLine("\t Go again!\n");
                    Thread.Sleep(200);
                } else if (choice == "rock" && cpuChoiceStr == "scissors" || choice == "scissors" && cpuChoiceStr == "paper" || choice == "paper" && cpuChoiceStr == "rock") {
                    Console.WriteLine("\t You win!\n");
                    Thread.Sleep(200);
                    Console.WriteLine("\t Press Enter to go to menu...");
                    Console.ReadLine();
                    break;
                } else if (choice == "scissors" && cpuChoiceStr == "rock" || choice == "rock" && cpuChoiceStr == "paper" || choice == "paper" && cpuChoiceStr == "scissors") {
                    Console.WriteLine("\t You lose!\n");
                    Thread.Sleep(200);
                    Console.WriteLine("\t Better luck next time...\n");
                    Thread.Sleep(200);
                    Console.WriteLine("\t Press Enter to go to menu...\n");
                    Console.ReadLine();
                    break;
                } else {
                    Console.WriteLine("\t Choose a valid option...\n");
                    Thread.Sleep(200);
                }
            }
        }
    }
}
