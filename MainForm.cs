namespace SnippetMaker
{
    public partial class MainForm : Form
    {
        //C:\Program Files\Microsoft Visual Studio\2022\Community\VC#\Snippets\1033\Visual C#

        private SnippetGenerator _snippetGenerator;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Loads the data.
            SaveLoad.Load();

            ComboBox_Language.SelectedIndex = 0;
        }

        private void ExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtrasForm extrasForm = new();
            extrasForm.Show();
        }

        private void UsingImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsingsForm usingsForm = new();
            usingsForm.Show();
        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            // Check if the snippet name is empty.
            if (string.IsNullOrEmpty(TextBox_SnippetName.Text))
            {
                MessageBox.Show("Snippet name cannot be empty.");
                return;
            }

            // Check if the snippet shortcut is empty.
            if (string.IsNullOrEmpty(TextBox_SnippetShortcut.Text))
            {
                MessageBox.Show("Snippet shortcut cannot be empty.");
                return;
            }

            // Check if the code is empty.
            if (string.IsNullOrEmpty(TextBox_Code.Text))
            {
                MessageBox.Show("Code cannot be empty.");
                return;
            }

            // Create a new instance of the SnippetGenerator class.
            _snippetGenerator = new(ComboBox_Language.Text);

            // Get the snippet name from the textbox.
            string snippetName = TextBox_SnippetName.Text;

            //// Decide on the description of the snippet.
            //string description = RichTextBox_Description.Text == "" ? snippetName : RichTextBox_Description.Text;

            //// Get the number of imports in the listbox.
            //int count = ListBox_Imports.Items.Count;

            //// Create an array to hold the imports.
            string[] imports = new string[0];

            //// Loop through the items in the listbox and add them to the imports array.
            //for (int i = 0; i < count; i++)
            //{
            //    imports[i] = ListBox_Imports.Items[i].ToString();
            //}

            // Generate the snippet code using the SnippetGenerator class.
            string snippet = _snippetGenerator.Generate(snippetName, TextBox_SnippetShortcut.Text, imports, TextBox_Code.Text,
                "", checkBox1.Checked);

            // Write the snippet code to a file.
            File.WriteAllText($"{snippetName}.snippet", snippet);

            MessageBox.Show("Generation is complete.");
        }

        private void Button_AddEnd_Click(object sender, EventArgs e)
        {
            TextBox_Code.Text += "$end$" + Environment.NewLine;
        }

        private void Button_AddSelected_Click(object sender, EventArgs e)
        {
            TextBox_Code.Text += "$selected$" + Environment.NewLine;
        }

        private void Button_AddField_Click(object sender, EventArgs e)
        {
            TextBox_Code.Text += "$field$" + Environment.NewLine;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox_Code.Text = SnippetGenerator.Description;
        }
    }
}