using System;
using System.Collections.Generic;
using MovieLibrary.Localization;

namespace MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new MovieManager();
            ICommand command;

            Console.WriteLine(LocalizationManager.Instance.GetString("welcome"));
            Console.WriteLine(LocalizationManager.Instance.GetString("helpPrompt"));

            while (true)
            {
                Console.Write("\n> ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input.ToLower() == "exit")
                {
                    break;
                }

                try
                {
                    command = CommandInterpreter.GetCommand(input);
                    command.Execute(manager, input.Contains(" ") ? input.Substring(input.IndexOf(' ') + 1) : "");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine(LocalizationManager.Instance.GetString("unknownCommand"));
                }
            }
        }
    }
}
