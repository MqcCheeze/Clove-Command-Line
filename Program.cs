using System;
using System.Threading;
using System.Linq;

namespace Clove__Command_Line_ {
    class Program {

        //main menu
        static void Main(string[] args) {
            while (true) {

                //variables for main menu
                string menuChosen;

                //main menu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t ▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓");
                Console.WriteLine("\t\t\t ▒▒▒                                             ▒▒▒");
                Console.Write("\t\t\t ▓▓▓  ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Welcome to Clove - A Multipurpose Program  ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("▓▓▓");
                Console.WriteLine("\t\t\t ▒▒▒                                             ▒▒▒");
                Console.WriteLine("\t\t\t ▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓");
                Console.WriteLine("\n");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.White;

                //asking for input
                Console.WriteLine("\t What menu would you like to access: fun | utilities | credits | exit\n");
                menuChosen = Console.ReadLine();
                Console.WriteLine("\n");

                //menu selection
                if (menuChosen.ToLower() == "fun") {
                    Thread.Sleep(500);
                    Console.Clear();
                    FunMenu();
                } else if (menuChosen.ToLower() == "utilities") {
                    Thread.Sleep(500);
                    Console.Clear();
                    UtilityMenu();
                } else if (menuChosen.ToLower() == "credits") {
                    Thread.Sleep(500);
                    Console.Clear();
                    Credits();
                } else if (menuChosen.ToLower() == "exit") {
                    Thread.Sleep(200);
                    Console.Clear();
                    Thread.Sleep(500);
                    Environment.Exit(0);
                } else {
                    //put user back into selection if none are chosen from the list
                    Console.WriteLine("\t Please choose a program from the following...\n\n");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }

        //fun menu
        static public void FunMenu() {

            //variables for fun
            string funChosen;

            //creating instance of NumberGuess game
            NumberGuess numGame = new NumberGuess();

            //creating instance of RockPaperScissors game
            RockPaperScissors rpsGame = new RockPaperScissors();

            while (true) {

                //fun menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t ▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒");
                Console.WriteLine("\t\t\t ▒▒▒            ▓▓▓");
                Console.Write("\t\t\t ▓▓▓  ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Fun Menu  ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("▒▒▒");
                Console.WriteLine("\t\t\t ▒▒▒            ▓▓▓");
                Console.WriteLine("\t\t\t ▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒");
                Console.WriteLine("\n");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.White;

                //asking for what game user wants
                Console.WriteLine("\t What game would you like to play: numguess - guess the number | rps - rock paper scissors | exit\n");
                funChosen = Console.ReadLine();
                Console.WriteLine("\n");
                
                //game selection if statements
                if (funChosen.ToLower() == "numguess") {
                    Thread.Sleep(500);
                    Console.Clear();
                    numGame.NumberGuessGame();
                } else if (funChosen.ToLower() == "rps") {
                    Thread.Sleep(500);
                    Console.Clear();
                    rpsGame.RockPaperScissorsGame();
                } else if (funChosen.ToLower() == "exit") {
                    Thread.Sleep(200);
                    Console.Clear();
                    break;
                } else {
                    Console.WriteLine("\t Please choose a game from the following...\n\n");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }

        //utility menu
        static public void UtilityMenu() {

            //variables for utility menu
            string utilityChosen;

            //creating instance of Calculator module
            Calculator calculator = new Calculator();

            //creating instance of Converter module
            Converter converter = new Converter();

            while (true) {

                //utility menu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t ▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒");
                Console.WriteLine("\t\t\t ▒▒▒                  ▓▓▓");
                Console.Write("\t\t\t ▓▓▓  ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Utilities Menu  ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("▒▒▒");
                Console.WriteLine("\t\t\t ▒▒▒                  ▓▓▓");
                Console.WriteLine("\t\t\t ▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒▓▓▓▒▒▒");
                Console.WriteLine("\n");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.White;

                //user selection
                Console.WriteLine("\t What utility would you like to use: calculator | converter | exit\n");
                utilityChosen = Console.ReadLine();
                Console.WriteLine("\n");

                //selected utility if statements
                if (utilityChosen.ToLower() == "calculator") {
                    Thread.Sleep(500);
                    Console.Clear();
                    calculator.CalculatorUtil();
                } else if (utilityChosen.ToLower() == "converter") {
                    Thread.Sleep(500);
                    Console.Clear();
                    converter.ConverterUtil();
                } else if (utilityChosen.ToLower() == "exit") {
                    Thread.Sleep(200);
                    Console.Clear();
                    break;
                } else {
                    Console.WriteLine("\t Please choose a program from the following...\n\n");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }

        //credits
        static public void Credits() {

            //creating instance of Credits module
            Credits credits = new Credits();
            credits.CreditsUtil();
        }
    }
}

//  --how to pull code from another class--
//
//      Class1 instance = new Class1();
//      instance.test();
//