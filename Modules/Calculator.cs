using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clove__Command_Line_ {
    public class Calculator {

        public void CalculatorUtil() {

            //variables for calculator
            string input;
            double firstNum;
            double secondNum;
            double finalNum;
            string operation;
            string outputMsg = "\t The answer is: ";

            //code ran once calculations have been completed
            void calcOutput() {
                Thread.Sleep(500);
                Console.WriteLine(outputMsg + finalNum + "\n");
                Console.WriteLine("-----------------------------------------------------\n");
                Thread.Sleep(1000);
                Console.WriteLine("\t Press enter to exit to menu...\n\n");
                Console.ReadLine();
                Console.Clear();
            }

            //drawing UI
            Console.WriteLine("\n\t\t\t ▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒");
            Console.WriteLine("\t\t\t ░░░                     ░░░");
            Console.WriteLine("\t\t\t ▒▒▒  Calculator Module  ▒▒▒");
            Console.WriteLine("\t\t\t ░░░                     ░░░");
            Console.WriteLine("\t\t\t ▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒\n");

            Thread.Sleep(500);
            while (true) {
                //first number
                Console.WriteLine("\n\t Enter first number:\n");
                input = Console.ReadLine();
                if (double.TryParse(input, out firstNum)) {
                    break;
                } else {
                    Console.WriteLine("\t Please enter a number...\n");
                    Thread.Sleep(500);
                }
            }

            Thread.Sleep(500);
            while (true) {
                //second number
                Console.WriteLine("\n\t Enter second number:\n");
                input = Console.ReadLine();
                if (double.TryParse(input, out secondNum)) {
                    Console.WriteLine("");
                    break;
                } else {
                    Console.WriteLine("\t Please enter a number...\n");
                    Thread.Sleep(500);
                }
            }

            while (true) {
                //operation selector
                Thread.Sleep(500);
                Console.WriteLine("\t Enter an opeartor: + | - | * | /\n");
                operation = Console.ReadLine();
                Console.WriteLine("\n");

                //if statements for calculation
                if (operation == "+") {
                    finalNum = firstNum + secondNum;
                    calcOutput();
                    break;
                } else if (operation == "-") {
                    finalNum = firstNum - secondNum;
                    calcOutput();
                    break;
                } else if (operation == "*") {
                    finalNum = firstNum * secondNum;
                    calcOutput();
                    break;
                } else if (operation == "/") {
                    finalNum = firstNum / secondNum;
                    calcOutput();
                    break;
                } else if (operation == "%") {
                    finalNum = firstNum % secondNum;
                    calcOutput();
                    break;
                } else {
                    Console.WriteLine("\t Please choose an avaliable operator...\n");
                    Thread.Sleep(500);
                }
            }
        }
    }
}
