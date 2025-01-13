using System;
using System.Linq;

namespace MovieLibrary
{
    public class ListCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            if (!manager.Movies.Any())
            {
                Console.WriteLine("No movies in the library.");
                return;
            }

            foreach (var movie in manager.Movies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
