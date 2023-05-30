using SnippetMaker.Forms;

namespace SnippetMaker
{
    public partial class MainForm : Form
    {
        //C:\Program Files\Microsoft Visual Studio\2022\Community\VC#\Snippets\1033\Visual C#

        public static RichTextBox CodeTextBox { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Loads the data.
            SaveLoad.Load();

            // Assigns the CodeTextBox reference to TextBox_Code
            CodeTextBox = TextBox_Code;

            // Sets the initial selected index of ComboBox_Language
            ComboBox_Language.SelectedIndex = 0;
        }

        #region ToolStripMenuItem Methods

        private void UsingImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsingsForm usingsForm = new();
            usingsForm.Show();
        }

        private void ExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtrasForm extrasForm = new();
            extrasForm.Show();
        }

        #endregion ToolStripMenuItem Methods

        #region Buttons Methods

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            // Check if the snippet name is empty.
            if (string.IsNullOrEmpty(TextBox_SnippetName.Text))
            {
                MessageBox.Show("Snippet name cannot be empty.");
                return;
            }
            // Check if the snippet shortcut is empty.
            else if (string.IsNullOrEmpty(TextBox_SnippetShortcut.Text))
            {
                MessageBox.Show("Snippet shortcut cannot be empty.");
                return;
            }
            // Check if the code is empty.
            else if (string.IsNullOrEmpty(TextBox_Code.Text))
            {
                MessageBox.Show("Code cannot be empty.");
                return;
            }
            else
            {
                // Create a new instance of the SnippetGenerator class.
                SnippetGenerator.Language = new(GetLanguage());

                // Generate the snippet code using the SnippetGenerator class.
                SnippetGenerator.Generate(TextBox_SnippetName.Text, TextBox_SnippetShortcut.Text, TextBox_Code.Text);
            }
        }

        private void Button_AddEnd_Click(object sender, EventArgs e)
        {
            InsertText("$end$");
        }

        private void Button_AddSelected_Click(object sender, EventArgs e)
        {
            InsertText("$selected$");
            SnippetGenerator.IsSurroundWith = true;
        }

        private void Button_AddDecleration_Click(object sender, EventArgs e)
        {
            DeclerationForm declerationForm = new();
            declerationForm.Show();
        }

        #endregion Buttons Methods

        #region Other Methods

        public static void InsertText(string text)
        {
            // Get the current cursor position
            int cursorPosition = CodeTextBox.SelectionStart;

            // Insert the desired text at the cursor position
            CodeTextBox.Text = CodeTextBox.Text.Insert(cursorPosition, text);

            // Move the cursor position to the end of the inserted text
            CodeTextBox.SelectionStart = cursorPosition + text.Length;
        }

        private string GetLanguage()
        {
            return ComboBox_Language.Text switch
            {
                "C#" => "csharp",
                "C++" => "cpp",
                "Visual Basic" => "VB",
                "JavaScript" => "JavaScript",
                "TypeScript" => "TypeScript",
                "Python" => "Python",
                "XML" => "XML",
                "CSS" => "css",
                "HTML" => "html",
                _ => "",
            };
        }

        #endregion Other Methods
    }
}