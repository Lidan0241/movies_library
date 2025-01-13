namespace MovieLibrary
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Year}), Directed by {Director}, Genre: {Genre}";
        }
    }
}