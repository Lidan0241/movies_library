using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using MovieLibrary;  // Importation de l'espace de noms contenant la classe Movie

namespace MovieLibrary
{
    public class MovieManager
    {
        public List<Movie> Movies { get; set; }
        private const string DefaultJsonPath = "data/movies.json";
        private const string LogFilePath = "data/movie_log.txt";

        public MovieManager()
        {
            Movies = LoadMoviesFromJson();
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
            SaveMoviesToJson();
            LogMovieAction(movie, "added");
        }

        private List<Movie> LoadMoviesFromJson()
        {
            return FileManager.DeserializeFromJson<List<Movie>>(DefaultJsonPath) ?? new List<Movie>();
        }

        private void SaveMoviesToJson()
        {
            FileManager.SerializeToJson(DefaultJsonPath, Movies);
        }

        private void LogMovieAction(Movie movie, string action)
        {
            string logEntry = $"{DateTime.Now}: Movie '{movie.Title}' was {action}\n";
            FileManager.WriteTextFile(LogFilePath, logEntry);
        }
    }
}
