using System;

namespace MovieLibrary
{
    public class WriteTextCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();
            
            Console.WriteLine("Enter content (press Ctrl+Z and Enter when done):");
            string content = "";
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                content += line + "\n";
            }

            FileManager.WriteTextFile($"data/{fileName}", content, false);
            Console.WriteLine($"Content written to data/{fileName}");
        }
    }
}
