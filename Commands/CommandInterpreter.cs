namespace MovieLibrary
{
    public static class CommandInterpreter
    {
        private static readonly HashSet<string> ValidLanguages = new HashSet<string> { "en", "zh" };

        public static ICommand GetCommand(string input)
        {
            string[] parts = input.Split(' ');
            string command = parts[0].ToLower();
            string arguments = parts.Length > 1 ? string.Join(" ", parts.Skip(1)) : "";

            // Check if input is a direct language code
            if (ValidLanguages.Contains(command))
            {
                return new LanguageCommand();
            }

            switch (command)
            {
                case "add":
                    return new AddMovieCommand();
                case "language":
                    return new LanguageCommand();
                case "list":
                    return new ListCommand();
                case "search":
                    return new SearchCommand();
                case "export":
                    return new ExportCommand();
                case "writetext":
                    return new WriteTextCommand();
                case "readstructured":
                    return new ReadStructuredCommand();
                case "writestructured":
                    return new WriteStructuredCommand();
                case "help":
                    return new HelpCommand();
                default:
                    throw new ArgumentException("Unknown command");
            }
        }
    }
}
