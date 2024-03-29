﻿namespace SnippetMaker
{
    public partial class ExtrasForm : Form
    {
        private readonly string _authorNameTag = "AuthorName";
        private readonly string _helpUrlTag = "HelpUrl";

        public ExtrasForm()
        {
            InitializeComponent();
        }

        private void ExtrasForm_Load(object sender, EventArgs e)
        {
            //Loads the data.
            TextBox_AuthorName.Text = SaveLoad.LoadString(_authorNameTag);
            TextBox_HelpUrl.Text = SaveLoad.LoadString(_helpUrlTag);

            //Resets the data description.
            TextBox_Description.Text = SnippetGenerator.Description;
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            //Saves the data.
            SaveLoad.SaveString(_authorNameTag, TextBox_AuthorName.Text);
            SaveLoad.SaveString(_helpUrlTag, TextBox_HelpUrl.Text);

            //Saves the data to file.
            SaveLoad.Save();

            //Sets description.
            SnippetGenerator.Description = TextBox_Description.Text;

            // Close the form
            Close();
        }
    }
}