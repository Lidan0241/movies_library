using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MovieLibrary.Localization
{
    public class LocalizationManager
    {
        private static LocalizationManager _instance;
        private Dictionary<string, string> _translations;
        private const string CONFIG_FILE = "language_config.json";
        
        public string CurrentLanguage { get; private set; } = "en";

        private LocalizationManager()
        {
            _translations = new Dictionary<string, string>();
            LoadLanguageConfig();
            LoadTranslations();
        }

        private void LoadLanguageConfig()
        {
            try
            {
                if (File.Exists(CONFIG_FILE))
                {
                    var config = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(CONFIG_FILE));
                    if (config.ContainsKey("language"))
                    {
                        CurrentLanguage = config["language"];
                    }
                }
            }
            catch (Exception)
            {
                CurrentLanguage = "en";
            }
        }

        private void SaveLanguageConfig()
        {
            try
            {
                var config = new Dictionary<string, string> { { "language", CurrentLanguage } };
                File.WriteAllText(CONFIG_FILE, JsonSerializer.Serialize(config));
            }
            catch (Exception) { }
        }

        private void LoadTranslations()
        {
            string filePath = Path.Combine("Resources", $"{CurrentLanguage}.json");
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                _translations = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonContent);
            }
            catch (Exception)
            {
                _translations = new Dictionary<string, string>();
            }
        }

        public bool SetLanguage(string language)
        {
            if (language != "en" && language != "zh") return false;
            CurrentLanguage = language;
            LoadTranslations();
            SaveLanguageConfig();
            return true;
        }

        public string GetString(string key)
        {
            return _translations.ContainsKey(key) ? _translations[key] : key;
        }

        public static LocalizationManager Instance
        {
            get
            {
                _instance ??= new LocalizationManager();
                return _instance;
            }
        }
    }
}
