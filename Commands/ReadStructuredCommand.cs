using System;

namespace MovieLibrary
{
    public class ReadStructuredCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            Console.Write("Enter file name to read: ");
            string fileName = Console.ReadLine();

            if (fileName.EndsWith(".json"))
            {
                var data = FileManager.DeserializeFromJson<List<Movie>>($"data/{fileName}");
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Unsupported format. Please use .json files.");
            }
        }
    }
}
