using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieLibrary
{
    public static class FileManager
    {
        public static void WriteTextFile(string filePath, string content, bool append = true)
        {
            try
            {
                if (append)
                {
                    File.AppendAllText(filePath, content);
                }
                else
                {
                    File.WriteAllText(filePath, content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public static string ReadTextFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return string.Empty;
            }
        }

        public static void SerializeToJson<T>(string filePath, T data)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error serializing to JSON: {ex.Message}");
            }
        }

        public static T DeserializeFromJson<T>(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing from JSON: {ex.Message}");
                return default;
            }
        }
    }
}
