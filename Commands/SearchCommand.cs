using System;
using System.Linq;

namespace MovieLibrary
{
    public class SearchCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            var results = manager.Movies
                .Where(m => m.Title.Contains(arguments, StringComparison.OrdinalIgnoreCase) ||
                            m.Director.Contains(arguments, StringComparison.OrdinalIgnoreCase) ||
                            m.Genre.Contains(arguments, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!results.Any())
            {
                Console.WriteLine("No matching movies found.");
                return;
            }

            foreach (var movie in results)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
