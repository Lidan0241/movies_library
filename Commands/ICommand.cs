namespace MovieLibrary
{
    public interface ICommand
    {
        void Execute(MovieManager manager, string arguments = "");
    }
}
