using System;

namespace MovieLibrary
{
    public class AddMovieCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            Console.WriteLine("Enter movie details:");
            
            Console.Write("Title: ");
            string title = Console.ReadLine();
            
            Console.Write("Director: ");
            string director = Console.ReadLine();
            
            Console.Write("Year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid year format.");
                return;
            }
            
            Console.Write("Genre: ");
            string genre = Console.ReadLine();

            var movie = new Movie
            {
                Title = title,
                Director = director,
                Year = year,
                Genre = genre
            };

            manager.AddMovie(movie);
            Console.WriteLine("Movie added successfully!");
        }
    }
}
