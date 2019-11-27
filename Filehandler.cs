using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MovieLibrary
{   // File reading and writing
    public class FileHandler
    {
        // File reading to a dictionary
        public static Dictionary<string, Dictionary<string, string>> DictFromFile(string filename)
        {        
            Dictionary<string, Dictionary<string, string>> database = new Dictionary<string, Dictionary<string, string>>();
            string[] allLines = File.ReadAllLines(filename); // transfering the contens of a file to a string array
            int index = 0;
            while (index < allLines.Length) // reading all the lines of the array
            {
                if (allLines[index].Contains("["))
                {
                    Dictionary<string, string> section = new Dictionary<string, string>();
                    string title = allLines[index];
                    title = title.Replace("[", string.Empty).Replace("]", string.Empty); // clearing the unwanted characters
                    index++;
                    section.Add("director", allLines[index].Replace("director=", null));
                    index++;
                    section.Add("release_year", allLines[index].Replace("release_year=", null));
                    index++;
                    section.Add("stars", allLines[index].Replace("stars=", null));
                    index++;
                    section.Add("budget", allLines[index].Replace("budget=", null));
                    index++;
                    database.Add(title, section);
                }
                else
                {
                    index++;
                }
            }  
            return database;
        }
        public static void DictToFile(string fileName, Dictionary<string, Dictionary<string, string>> dataBase)
        {
            StringBuilder iniText = new StringBuilder();           
            foreach (string record in dataBase.Keys)
            {
                iniText.AppendLine("[" + record + "]");
                iniText.AppendLine("director=" + dataBase[record]["director"]);
                iniText.AppendLine("release_year=" + dataBase[record]["release_year"]);
                iniText.AppendLine("stars=" + dataBase[record]["stars"]);
                iniText.AppendLine("budget=" + dataBase[record]["budget"]);
                iniText.AppendLine();   
            }
            string finalText = iniText.ToString();
            File.WriteAllText(fileName, finalText);
        }
    }
}
