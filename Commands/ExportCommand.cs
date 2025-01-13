using System;

namespace MovieLibrary
{
    public class ExportCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            if (string.IsNullOrWhiteSpace(arguments))
            {
                Console.WriteLine("Please specify export format (json/txt)");
                return;
            }

            switch (arguments.ToLower())
            {
                case "json":
                    FileManager.SerializeToJson("data/export.json", manager.Movies);
                    Console.WriteLine("Movies exported to data/export.json");
                    break;
                case "txt":
                    var content = string.Join("\n", manager.Movies);
                    FileManager.WriteTextFile("data/export.txt", content, false);
                    Console.WriteLine("Movies exported to data/export.txt");
                    break;
                default:
                    Console.WriteLine("Unsupported format. Use 'json' or 'txt'");
                    break;
            }
        }
    }
}
