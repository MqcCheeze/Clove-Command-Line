using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clove__Command_Line_ {
    public class Credits {
        public void CreditsUtil() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t ▓▓▓▒▒▒▒▓▓▓▒▒▒▒▓▓▓");
            Console.WriteLine("\t\t\t ▒▒▒           ▒▒▒");
            Console.Write("\t\t\t ▓▓▓  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Credits  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("▓▓▓");
            Console.WriteLine("\t\t\t ▒▒▒           ▒▒▒");
            Console.WriteLine("\t\t\t ▓▓▓▒▒▒▒▓▓▓▒▒▒▒▓▓▓\n");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;

            //credits
            Console.WriteLine("\t Program developed by MqcCheeze (self taught)\n");
            Thread.Sleep(100);
            Console.WriteLine("\t Inspiration from Starvedllama's 'Clover AI'\n");
            Thread.Sleep(100);
            Console.WriteLine("\t Written in C# Visual Studio 2022\n");
            Thread.Sleep(100);
            Console.WriteLine("\t Using .NET Core 3.1\n\n");
            Thread.Sleep(100);
            Console.WriteLine("\t\t\t    MqcCheeze on GitHub 2021\n\n\n");
            Thread.Sleep(1000);
            Console.WriteLine("\t\t Press enter to exit to menu...\n\n");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
