using System;
using System.IO;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 3) {

                string textfilepath = args[1];
                string keyfilepath = args[2];

                if (!File.Exists(textfilepath)) {
                    Console.WriteLine("Text file doesn't exist");
                    return;
                }

                if (!File.Exists(keyfilepath)) {
                    Console.WriteLine("Key file doesn't exist");
                    return;
                }

                // Encriptar
                if (args[0] == "-e") {
                    Console.WriteLine("Encrypt operation");
                    string text = File.ReadAllText(textfilepath);

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
