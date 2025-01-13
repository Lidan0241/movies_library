using MovieLibrary.Localization;
namespace MovieLibrary
{
    public class HelpCommand : ICommand
    {
        public void Execute(MovieManager manager, string arguments = "")
        {
            var localizationManager = LocalizationManager.Instance;
            Console.WriteLine(localizationManager.GetString("availableCommands"));
            Console.WriteLine(localizationManager.GetString("helpAdd"));
            Console.WriteLine(localizationManager.GetString("helpSearch"));
            Console.WriteLine(localizationManager.GetString("helpList"));
            Console.WriteLine(localizationManager.GetString("helpLanguage"));
            Console.WriteLine(localizationManager.GetString("helpExport"));
            Console.WriteLine(localizationManager.GetString("helpWriteText"));
            Console.WriteLine(localizationManager.GetString("helpReadStructured"));
            Console.WriteLine(localizationManager.GetString("helpWriteStructured"));
            Console.WriteLine(localizationManager.GetString("helpHelp"));
            Console.WriteLine(localizationManager.GetString("helpExit"));
        }
    }
}
