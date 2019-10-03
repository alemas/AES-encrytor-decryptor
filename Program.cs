using System;
using System.IO;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 3) {

                string filepath = args[1];

                if (!File.Exists(filepath)) {
                    Console.WriteLine("File doesn't exist");
                    return;
                }

                // Encriptar
                if (args[0] == "-e") {
                    Console.WriteLine("Encrypt operation");

                // Decriptar
                } else if (args[0] == "-d") {
                    Console.WriteLine("Decrypt operation");

                } else  {
                    Program.ShowHelp();
                }
            } else {
                Program.ShowHelp();
            }

            for (int i = 1; i < args.Length; i++)
            {
                string arg = args[i];
                if (arg == "-e") {

                }
            }
            
        }

        private static void ShowHelp() 
        {
            Console.WriteLine("Usage: dotnet run Program [-e|-d] text-filepath key-filepath [-cbc|-ctr]");
        }

        private static string Encrypt(string text) 
        {

            return "";
        }
    }
}
