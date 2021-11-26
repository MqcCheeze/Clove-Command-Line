using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clove__Command_Line_ {
    public class NaughtsCrosses {
        public void NaughtsCrossesGame() {

            //variables
            string inputGo;
            int input;
            string rounds;
            Random CPUGo = new Random();
            int CPUinput;
            int numOfRounds;
            string roundLength;
            Random firstGo = new Random();
            int first;
            string youLost = "\n\t The computer won the round!";
            string youWon = "\n\t You won the round!";
            string next = "\n\t Press Enter to go to the next round...";
            bool win = false;

            //2D array creation
            string[,] grid = new string[3, 3] {
                {"[]","[]","[]"},
                {"[]","[]","[]"},
                {"[]","[]","[]"}
            };

            //cpu make a choice and see if its in an avaliable spot
            void cpuINPUT() {
                while (true) {
                    CPUinput = CPUGo.Next(1, 10);

                    if (grid[0, 0] == "[]" && CPUinput == 1) {
                        grid[0, 0] = "[X]";
                        break;
                    } else if (grid[0, 1] == "[]" && CPUinput == 2) {
                        grid[0, 1] = "[X]";
                        break;
                    } else if (grid[0, 2] == "[]" && CPUinput == 3) {
                        grid[0, 2] = "[X]";
                        break;
                    } else if (grid[1, 0] == "[]" && CPUinput == 4) {
                        grid[1, 0] = "[X]";
                        break;
                    } else if (grid[1, 1] == "[]" && CPUinput == 5) {
                        grid[1, 1] = "[X]";
                        break;
                    } else if (grid[1, 2] == "[]" && CPUinput == 6) {
                        grid[1, 2] = "[X]";
                        break;
                    } else if (grid[2, 0] == "[]" && CPUinput == 7) {
                        grid[2, 0] = "[X]";
                        break;
                    } else if (grid[2, 1] == "[]" && CPUinput == 8) {
                        grid[2, 1] = "[X]";
                        break;
                    } else if (grid[2, 2] == "[]" && CPUinput == 9) {
                        grid[2, 2] = "[X]";
                        break;
                    }
                }
            }

            //code to draw grid
            void drawGrid() {
                Console.Clear();
                Console.WriteLine("\n\t\t\t 1\t 2\t 3");
                Console.WriteLine("\t\t\t " + grid[0, 0] + "\t " + grid[0, 1] + "\t " + grid[0, 2]);
                Console.WriteLine("\n\n\t\t\t 4\t 5\t 6");
                Console.WriteLine("\t\t\t " + grid[1, 0] + "\t " + grid[1, 1] + "\t " + grid[1, 2]);
                Console.WriteLine("\n\n\t\t\t 7\t 8\t 9");
                Console.WriteLine("\t\t\t " + grid[2, 0] + "\t " + grid[2, 1] + "\t " + grid[2, 2]);
                Thread.Sleep(200);
            }

            //code for win
            void winText() {
                Console.WriteLine(youWon);
                Console.WriteLine(next);
                Console.ReadLine();
                Console.Clear();
            }

            //code for CPU win
            void loseText() {
                Console.WriteLine(youLost);
                Console.WriteLine(next);
                Console.ReadLine();
                Console.Clear();
            }

            //check to see if anyone has won
            void checkWin() {
                if (grid[0, 0] == "[O]" && grid[0, 1] == "[O]" && grid[0, 2] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[1, 0] == "[O]" && grid[1, 1] == "[O]" && grid[1, 2] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[2, 0] == "[O]" && grid[2, 1] == "[O]" && grid[2, 2] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[0, 0] == "[O]" && grid[1, 0] == "[O]" && grid[2, 0] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[0, 1] == "[O]" && grid[1, 1] == "[O]" && grid[2, 1] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[0, 2] == "[O]" && grid[1, 2] == "[O]" && grid[2, 2] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[0, 0] == "[O]" && grid[1, 1] == "[O]" && grid[2, 2] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[0, 2] == "[O]" && grid[1, 1] == "[O]" && grid[2, 0] == "[O]") {
                    winText();
                    win = true;
                } else if (grid[0, 0] == "[X]" && grid[0, 1] == "[X]" && grid[0, 2] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[1, 0] == "[X]" && grid[1, 1] == "[X]" && grid[1, 2] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[2, 0] == "[X]" && grid[2, 1] == "[X]" && grid[2, 2] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[0, 0] == "[X]" && grid[1, 0] == "[X]" && grid[2, 0] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[0, 1] == "[X]" && grid[1, 1] == "[X]" && grid[2, 1] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[0, 2] == "[X]" && grid[1, 2] == "[X]" && grid[2, 2] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[0, 0] == "[X]" && grid[1, 1] == "[X]" && grid[2, 2] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[0, 2] == "[X]" && grid[1, 1] == "[X]" && grid[2, 0] == "[X]") {
                    loseText();
                    win = true;
                } else if (grid[0, 0] != "[]" && grid[0, 1] != "[]" && grid[0, 2] != "[]" && grid[1, 0] != "[]" && grid[1, 1] != "[]" && grid[1, 2] != "[]" && grid[2, 0] != "[]" && grid[2, 1] != "[]" && grid[2, 2] != "[]") {
                    Console.WriteLine("\n\t No one won this round...");
                    win = true;
                    Console.WriteLine(next);
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            //gui
            Console.WriteLine("\n\t\t\t ▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒");
            Console.WriteLine("\t\t\t ░░░                     ░░░");
            Console.WriteLine("\t\t\t ▒▒▒  Naughts & Crosses  ▒▒▒");
            Console.WriteLine("\t\t\t ░░░                     ░░░");
            Console.WriteLine("\t\t\t ▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒");
            Console.WriteLine("\t\t\t\t    \n");
            Thread.Sleep(500);
            
            //user game length
            while (true) {
                Console.WriteLine("\n\t How many rounds would you like to play:\n");
                rounds = Console.ReadLine();
                if (int.TryParse(rounds, out numOfRounds)) {
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

            //round
            Thread.Sleep(500);
            Console.WriteLine("\n");
            for (int i = 1; i <= numOfRounds; i++) {

                //reset game
                win = false;

                //round length UI box correction
                roundLength = i.ToString();
                if (roundLength.Length == 2) {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t ▓▓▓▒▒▒▒▓▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒            ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓  Round " + i + "  ▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒            ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓▒▒▒▒▓▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t\t    \n");
                    Thread.Sleep(1500);
                } else {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t ▓▓▓▒▒▒▒▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒           ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓  Round " + i + "  ▓▓▓");
                    Console.WriteLine("\t\t\t ▒▒▒           ▒▒▒");
                    Console.WriteLine("\t\t\t ▓▓▓▒▒▒▒▓▓▓▒▒▒▒▓▓▓");
                    Console.WriteLine("\t\t\t\t    \n");
                    Thread.Sleep(1500);
                }

                //reset grid
                grid = new string[3, 3] {
                {"[]","[]","[]"},
                {"[]","[]","[]"},
                {"[]","[]","[]"}
                };
                //game
                while (true) {
                    drawGrid();

                    //who goes first
                    first = firstGo.Next(1, 3);
                    switch (first) {
                        //if user goes first
                        case 1:
                            break;
                        //if CPU goes first
                        case 2:
                            cpuINPUT();
                            drawGrid();
                            break;
                    }
                    
                    //user input
                    while (true) {
                        Console.WriteLine("\n\t You are 'O'");
                        Console.WriteLine("\t Choose a space corresponding with the number:\n");
                        inputGo = Console.ReadLine();
                        if (int.TryParse(inputGo, out input)) {

                            while (true) {
                                if (grid[0, 0] == "[]" && input == 1) {
                                    grid[0, 0] = "[O]";
                                    break;
                                } else if (grid[0, 1] == "[]" && input == 2) {
                                    grid[0, 1] = "[O]";
                                    break;
                                } else if (grid[0, 2] == "[]" && input == 3) {
                                    grid[0, 2] = "[O]";
                                    break;
                                } else if (grid[1, 0] == "[]" && input == 4) {
                                    grid[1, 0] = "[O]";
                                    break;
                                } else if (grid[1, 1] == "[]" && input == 5) {
                                    grid[1, 1] = "[O]";
                                    break;
                                } else if (grid[1, 2] == "[]" && input == 6) {
                                    grid[1, 2] = "[O]";
                                    break;
                                } else if (grid[2, 0] == "[]" && input == 7) {
                                    grid[2, 0] = "[O]";
                                    break;
                                } else if (grid[2, 1] == "[]" && input == 8) {
                                    grid[2, 1] = "[O]";
                                    break;
                                } else if (grid[2, 2] == "[]" && input == 9) {
                                    grid[2, 2] = "[O]";
                                    break;
                                } else {
                                    Console.WriteLine("\t Please choose an avaliable grid...\n");
                                    inputGo = Console.ReadLine();
                                    if (int.TryParse(inputGo, out input)) {
                                    } else {
                                        Console.WriteLine("\t Please choose a grid space...\n");
                                    }
                                    Thread.Sleep(500);
                                }
                            }
                            
                            //update the game and see if anyone has won
                            drawGrid();
                            checkWin();
                            //if someone has won then next round
                            if (win == true) {
                                break;
                            }

                            Thread.Sleep(500);

                            //CPU makes turn
                            cpuINPUT();
                            //update the game and see if anyone has won
                            drawGrid();
                            checkWin();
                            //if someone has won then next round
                            if (win == true) {
                                break;
                            }

                        //if a non existance space is chosen
                        } else {
                            Console.WriteLine("\t Please choose a grid space...\n");
                        }
                    }
                    break;
                }
            }
        }
    }
}
