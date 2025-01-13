using System;
using MovieLibrary.Localization;
using System.Collections.Generic;

namespace MovieLibrary
{
    public class LanguageCommand : ICommand
    {
        private static readonly HashSet<string> ValidLanguages = new HashSet<string> { "en", "zh" };

        public void Execute(MovieManager manager, string arguments = "")
        {
            // If the input is just a valid language code, treat it as a language change request
            if (!string.IsNullOrWhiteSpace(arguments) && ValidLanguages.Contains(arguments.ToLower().Trim()))
            {
                SetLanguage(arguments);
                return;
            }

            if (string.IsNullOrWhiteSpace(arguments))
            {
                Console.WriteLine("Available languages:");
                Console.WriteLine("- en (English)");
                Console.WriteLine("- zh (Chinese)");
                Console.WriteLine("\nCurrent language: " + LocalizationManager.Instance.CurrentLanguage);
                return;
            }
        }

        private void SetLanguage(string language)
        {
            language = language.ToLower().Trim();
            if (LocalizationManager.Instance.SetLanguage(language))
            {
                Console.WriteLine($"Language changed to: {language}");
            }
            else
            {
                Console.WriteLine($"Invalid language code '{language}'.");
                Console.WriteLine("Available languages: en, zh");
            }
        }
    }
}
