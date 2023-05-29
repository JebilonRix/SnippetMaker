namespace SnippetMaker.Forms
{
    public partial class DeclerationForm : Form
    {
        public DeclerationForm()
        {
            InitializeComponent();
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            // Check if the ID is empty
            if (string.IsNullOrEmpty(TextBox_ID.Text))
            {
                MessageBox.Show("ID cannot be empty.");
                return;
            }
            else
            {
                // Create a new Declaration object with the entered values
                Declaration declaration = new()
                {
                    ID = TextBox_ID.Text,
                    ToolTip = TextBox_ToolTip.Text,
                    Default = TextBox_Default.Text,
                    Function = ComboBox_Function.Text
                };

                // Set the default value to the ID if it is empty
                if (string.IsNullOrEmpty(TextBox_Default.Text))
                {
                    declaration.Default = TextBox_ID.Text;
                }

                // Add the Declaration to the DeclarationList in SnippetGenerator class
                SnippetGenerator.DeclarationList.Add(declaration);

                // Append the declaration ID to the CodeTextBox in MainForm
                MainForm.InsertText($"${declaration.ID}$");

                // Close the form
                Close();
            }
        }
    }
}