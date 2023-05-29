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
            // Check if ID is empty
            if (string.IsNullOrEmpty(TextBox_ID.Text))
            {
                MessageBox.Show("ID cannot be empty.");
                return;
            }
            // Check if Default value is empty
            else if (string.IsNullOrEmpty(TextBox_Default.Text))
            {
                MessageBox.Show("Default value cannot be empty.");
                return;
            }
            else
            {
                // Create a new Declaration object with the entered values
                Declaration declaration = new Declaration()
                {
                    ID = TextBox_ID.Text,
                    ToolTip = TextBox_ToolTip.Text,
                    Default = TextBox_Default.Text,
                    Function = TextBox_Function.Text
                };

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