using System.Text;

namespace SnippetMaker
{
    public static class SnippetGenerator
    {
        private static readonly StringBuilder stringBuilder = new();

        public static string Description { get; set; } = "";
        public static string Language { get; set; } = "";
        public static bool IsSurroundWith { get; set; } = false;
        public static List<string> UsingsList { get; private set; } = new();
        public static List<Declaration> DeclarationList { get; private set; } = new();

        public static void Reset()
        {
            // Reset the Description, Language and IsSurroundWith
            Description = "";
            Language = "";
            IsSurroundWith = false;

            // Clear the UsingsList and DeclarationList
            UsingsList.Clear();
            DeclarationList.Clear();

            // Clear the stringBuilder
            stringBuilder.Clear();
        }

        public static void Generate(string snippetName, string snippetShortcut, string code)
        {
            code = CodeTextHandle(code);

            string documentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string snippetsDirectory = Path.Combine(documentsDirectory, "Visual Studio 2022", "Code Snippets");

            // Show save file dialog to choose the location to save the snippet file
            SaveFileDialog saveFileDialog = new()
            {
                FileName = $"{snippetName}.snippet",
                Filter = "Snippet Files (*.snippet)|*.snippet",
                Title = "Save Snippet File",
                InitialDirectory = snippetsDirectory
            };

            // User canceled the save operation
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // Update the snippet file path with the chosen location
            string snippetFilePath = saveFileDialog.FileName;

            // Add the XML header and CodeSnippets element
            stringBuilder.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n");
            stringBuilder.Append("<CodeSnippets xmlns=\"http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet\">\n");

            // Add the CodeSnippet element and Header element
            stringBuilder.Append("<CodeSnippet Format=\"1.0.0\">\n");
            HeaderHandle(snippetName, snippetShortcut);

            // Open the Snippet element and Imports element
            stringBuilder.Append("<Snippet>\n");

            // Handle import
            ImportHandle();

            // Handle declaration
            DeclarationHandle();

            // Handle code
            CodeHandle(code);

            // Close the Snippet element and Imports element
            stringBuilder.Append("</Snippet>\n");
            stringBuilder.Append("</CodeSnippet>\n");
            stringBuilder.Append("</CodeSnippets>");

            // Write the snippet code to a file.
            File.WriteAllText(snippetFilePath, stringBuilder.ToString());

            // Resets the generator.
            Reset();
        }

        private static string CodeTextHandle(string code)
        {
            // Split the code string into an array of substrings using '$' as the delimiter
            string[] splittedString = code.Split('$');

            // Count the occurrences of "end" and "selected"
            int endCount = 0;
            int selectedCount = 0;

            foreach (string item in splittedString)
            {
                if (item == "end")
                {
                    endCount++;
                }
                else if (item == "selected")
                {
                    selectedCount++;

                    // Set the IsSurroundWith flag to true if "selected" is found
                    IsSurroundWith = true;
                }
            }

            // Remove all occurrences of "end" except the last one
            if (endCount > 1)
            {
                List<string> modifiedStringList = new List<string>();

                foreach (string item in splittedString)
                {
                    if (item == "end" && endCount > 1)
                    {
                        endCount--;

                        // Skip this occurrence of "end" if there are more than one
                        continue;
                    }

                    modifiedStringList.Add(item);
                }

                splittedString = modifiedStringList.ToArray();
            }

            // Remove all occurrences of "selected" except the last one
            if (selectedCount > 1)
            {
                List<string> modifiedStringList = new List<string>();

                foreach (string item in splittedString)
                {
                    if (item == "selected" && selectedCount > 1)
                    {
                        selectedCount--;

                        // Skip this occurrence of "selected" if there are more than one
                        continue;
                    }

                    modifiedStringList.Add(item);
                }

                splittedString = modifiedStringList.ToArray();
            }

            // Reconstruct the code string with modified occurrences of "end" and "selected"
            string result = "";

            foreach (string item in splittedString)
            {
                if (item == "end" || item == "selected")
                {
                    // Add '$' symbols to "end" and "selected" occurrences
                    result += $"${item}$";
                }
                else
                {
                    // Add other substrings as they are
                    result += item;
                }
            }

            return result;
        }

        private static void HeaderHandle(string snippetName, string snippetShortcut)
        {
            // Open the "Header" element
            stringBuilder.Append("<Header>\n");

            // Open the "SnippetTypes" element
            stringBuilder.Append("<SnippetTypes>\n");

            // Handle expansion
            stringBuilder.Append(TagLineHandle("Expansion", "SnippetType"));

            // Add "SurroundsWith" snippet type if IsSurroundWith is true
            if (IsSurroundWith)
            {
                // Handle surround with
                stringBuilder.Append(TagLineHandle("SurroundsWith", "SnippetType"));
            }

            // Close the "SnippetTypes" element
            stringBuilder.Append("</SnippetTypes>\n");

            // Add the "Title", "Author", "Description", "HelpUrl", and "Shortcut" elements
            stringBuilder.Append(TagLineHandle(snippetName, "Title"));
            stringBuilder.Append(TagLineHandle(SaveLoad.LoadString("AuthorName"), "Author"));
            stringBuilder.Append(TagLineHandle(Description, "Description"));
            stringBuilder.Append(TagLineHandle(SaveLoad.LoadString("HelpUrl"), "HelpUrl"));
            stringBuilder.Append(TagLineHandle(snippetShortcut, "Shortcut"));

            // Close the "Header" element
            stringBuilder.Append("</Header>\n");
        }

        private static void ImportHandle()
        {
            if (UsingsList.Count != 0)
            {
                // Open the "Imports" element
                stringBuilder.Append("<Imports>\n");

                // Add each import as a separate "Namespace" element
                foreach (string import in UsingsList)
                {
                    // Open the "Import" element
                    stringBuilder.Append("<Import>\n");

                    // Append the "Namespace" element with the import value
                    stringBuilder.Append(TagLineHandle(import, "Namespace"));

                    // Close the "Import" element
                    stringBuilder.Append("</Import>\n");
                }

                // Close the "Imports" element
                stringBuilder.Append("</Imports>\n");
            }
        }

        private static void DeclarationHandle()
        {
            if (DeclarationList.Count != 0)
            {
                // Append the "Declarations" start tag
                stringBuilder.Append("<Declarations>");

                foreach (Declaration declaration in DeclarationList)
                {
                    // Append the "<Literal Editable="true">" start tag
                    stringBuilder.Append("<Literal Editable=\"true\">");

                    // Append the tag lines for each property of the Declaration object
                    stringBuilder.Append(TagLineHandle(declaration.ID, "ID"));
                    stringBuilder.Append(TagLineHandle(declaration.ToolTip, "ToolTip"));
                    stringBuilder.Append(TagLineHandle(declaration.Default, "Default"));
                    stringBuilder.Append(TagLineHandle(declaration.Function, "Function"));

                    // Append the closing tag for the "<Literal>" element
                    stringBuilder.Append("</Literal>");
                }

                // Append the closing tag for the "Declarations" element
                stringBuilder.Append("</Declarations>");
            }
        }

        private static void CodeHandle(string code)
        {
            // Add the "Code" element and CDATA section for the code
            stringBuilder.Append($"<Code Language=\"{Language}\" Delimiter=\"$\">\n");

            // Append the code within a CDATA section, trimming any trailing whitespace
            stringBuilder.Append($"<![CDATA[{code.TrimEnd(null)}]]>\n");

            // Close the "Code" element
            stringBuilder.Append("</Code>\n");
        }

        private static string TagLineHandle(string word, string tag)
        {
            return $"<{tag}>{word}</{tag}>\n";
        }
    }
}