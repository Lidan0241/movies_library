using System;

namespace MovieLibrary
{
    public class WriteStructuredCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            Console.Write("Enter file name (with .json extension): ");
            string fileName = Console.ReadLine();

            if (!fileName.EndsWith(".json"))
            {
                Console.WriteLine("Only JSON format is supported.");
                return;
            }

            FileManager.SerializeToJson($"data/{fileName}", manager.Movies);
            Console.WriteLine($"Data written to data/{fileName}");
        }
    }
}
