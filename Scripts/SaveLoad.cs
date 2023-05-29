using Newtonsoft.Json;
using System.Diagnostics;
using Formatting = Newtonsoft.Json.Formatting;

namespace SnippetMaker
{
    public static class SaveLoad
    {
        //Save paths.
        private static readonly string _saveInfoFilePath = Path.Combine(Application.StartupPath, "info.txt");
        private static readonly string _saveUsingsFilePath = Path.Combine(Application.StartupPath, "usings.txt");

        //Dictionarys
        private static readonly Dictionary<string, string> _stringDictionary = new();
        private static readonly Dictionary<string, List<string>> _listDictionary = new();

        #region Save

        public static void Save()
        {
            try
            {
                // Create a dictionary to store the file paths and corresponding JSON strings
                Dictionary<string, string> saves = new();

                // Add string dictionary
                saves.Add(_saveInfoFilePath, SerializeDictionary(_stringDictionary));

                // Add list dictionary
                saves.Add(_saveUsingsFilePath, SerializeDictionary(_listDictionary));

                // Iterate through each key-value pair in the saves dictionary
                foreach (KeyValuePair<string, string> save in saves)
                {
                    // Open a StreamWriter using the save file path
                    using (StreamWriter writer = new(save.Key))
                    {
                        // Write the JSON string to the file
                        writer.Write(save.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"An error occurred while saving data: {ex.Message}");
            }
        }

        private static string SerializeDictionary<T>(Dictionary<string, T> dictionary)
        {
            // Serialize the dictionary to JSON with indented formatting
            return JsonConvert.SerializeObject(dictionary, Formatting.Indented);
        }

        public static void SaveString(string tag, string value)
        {
            // Check if the tag already exists in the dictionary
            if (!_stringDictionary.ContainsKey(tag))
            {
                // Add the new tag and value to the dictionary
                _stringDictionary.Add(tag, value);
            }
            else
            {
                // Update the existing value for the given tag
                _stringDictionary[tag] = value;
            }

            Save();
        }

        public static void SaveList(string tag, List<string> value)
        {
            // Check if the tag already exists in the dictionary
            if (!_listDictionary.ContainsKey(tag))
            {
                // Add the new tag and value to the dictionary
                _listDictionary.Add(tag, value);
            }
            else
            {
                // Update the existing value for the given tag
                _listDictionary[tag] = value;
            }

            Save();
        }

        #endregion Save

        #region Load

        public static void Load()
        {
            try
            {
                // Load string dictionary
                LoadDictionary(_saveInfoFilePath, _stringDictionary);

                // Load list dictionary
                LoadDictionary(_saveUsingsFilePath, _listDictionary);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the loading process
                Debug.WriteLine($"Error occurred while loading data: {ex.Message}");
            }
        }

        private static void LoadDictionary<T>(string filePath, Dictionary<string, T> dictionary)
        {
            // If the save file does not exist, create it
            if (!File.Exists(filePath))
            {
                // Close the FileStream after creating the file
                File.Create(filePath).Close();
            }

            // Read the JSON content from the file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON into a dictionary object
            Dictionary<string, T>? loadedDictionary = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);

            if (loadedDictionary != null)
            {
                // Iterate through each item in the loaded dictionary
                foreach (KeyValuePair<string, T> item in loadedDictionary)
                {
                    // Add or update the corresponding item in the target dictionary
                    dictionary[item.Key] = item.Value;
                }
            }
        }

        public static string LoadString(string tag)
        {
            // Check if the tag exists in the dictionary
            if (_stringDictionary.ContainsKey(tag))
            {
                // Return the corresponding value for the given tag
                return _stringDictionary[tag];
            }
            else
            {
                // Return an empty string if the tag does not exist
                return "";
            }
        }

        public static List<string> LoadList(string tag)
        {
            // Check if the tag exists in the dictionary
            if (_listDictionary.ContainsKey(tag))
            {
                // Return the corresponding value for the given tag
                return _listDictionary[tag];
            }
            else
            {
                // Return an empty list if the tag does not exist
                return new List<string>();
            }
        }

        #endregion Load
    }
}