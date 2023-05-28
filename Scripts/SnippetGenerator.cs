using System.Text;

namespace SnippetMaker
{
    internal class SnippetGenerator
    {
        private readonly string _language;

        public static string Description { get; set; } = "";
        public static List<string> UsingsList { get; private set; } = new();

        public SnippetGenerator(string language)
        {
            _language = language;
        }

        // Generate the code snippet
        public string Generate(string snippetName, string snippetShortcut, string[] imports, string code, string description, bool isSurroundWith)
        {
            // Create a new StringBuilder to hold the result
            StringBuilder sb = new();

            // Add the XML header and CodeSnippets element
            sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n");
            sb.Append("<CodeSnippets xmlns=\"http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet\">\n");

            // Add the CodeSnippet element and Header element
            sb.Append("<CodeSnippet Format=\"1.0.0\">\n");
            sb.Append("<Header>\n");

            // Add the SnippetTypes element
            sb.Append("<SnippetTypes>\n");
            sb.Append("<SnippetType>Expansion</SnippetType>\n");

            // Add SurroundsWith snippet type if isSurroundWith is true
            if (isSurroundWith)
            {
                sb.Append("<SnippetType>SurroundsWith</SnippetType>\n");
            }

            //Close snippet types element.
            sb.Append("</SnippetTypes>\n");

            // Add the Title, Author, Description, HelpUrl, and Shortcut elements
            sb.Append($"<Title>{snippetName}</Title>\n");
            sb.Append($"<Author>{SaveLoad.LoadString("AuthorName")}</Author>\n");
            sb.Append($"<Description>{description}</Description>\n");
            //sb.Append($"<HelpUrl>{helpUrl}</HelpUrl>\n");
            sb.Append($"<Shortcut>{snippetShortcut}</Shortcut>\n");

            // Close the Header element
            sb.Append("</Header>\n");

            // Add the Snippet element and Imports element
            sb.Append("<Snippet>\n");
            sb.Append("<Imports>\n");

            // Add each import as a separate Namespace element
            foreach (string import in imports)
            {
                sb.Append("<Import>\n" + $"<Namespace>{import}</Namespace>\n" + "</Import>\n");
            }

            //Close the imports elements
            sb.Append("</Imports>\n");

            //Add the Code element and CDATA section for the code
            sb.Append($"<Code Language=\"{_language}\" Delimiter=\"$\">\n");
            sb.Append($"<![CDATA[{code.TrimEnd(null)}]]>\n");

            //Close the remaining elements
            sb.Append("</Code>\n" + "</Snippet>\n" + "</CodeSnippet>\n" + "</CodeSnippets>");

            //Convert the StringBuilder to a string and return it
            return sb.ToString();
        }
    }
}