namespace SnippetMaker
{
    public partial class UsingsForm : Form
    {
        private readonly string _listTag = "UsingList";

        public UsingsForm()
        {
            InitializeComponent();
        }

        private void UsingsForm_Load(object sender, EventArgs e)
        {
            // Clear the items in ListBox1
            ListBox1.Items.Clear();

            // Load the list of strings from the saved data using the given tag
            List<string> usingList = SaveLoad.LoadList(_listTag);

            // Sort the list
            usingList.Sort();

            // Iterate through each item in the loaded list
            foreach (string item in usingList)
            {
                // Add each item to ListBox1
                ListBox1.Items.Add(item);
            }

            // Iterate through each item in SnippetGenerator.DeclarationList
            foreach (string item in SnippetGenerator.UsingsList)
            {
                // Add each item to ListBox2
                ListBox2.Items.Add(item);

                // Remove each item from ListBox1
                ListBox1.Items.Remove(item);
            }
        }

        private void Button_ToLeft_Click(object sender, EventArgs e)
        {
            // Check if an decleration is selected in ListBox1
            if (ListBox1.SelectedItem != null)
            {
                // Get the selected decleration as a string
                string selectedItem = ListBox1.SelectedItem.ToString();

                // Add the selected decleration to ListBox2
                ListBox2.Items.Add(selectedItem);

                // Remove the selected decleration from ListBox1
                ListBox1.Items.Remove(selectedItem);
            }
        }

        private void Button_ToRight_Click(object sender, EventArgs e)
        {
            // Check if an decleration is selected in ListBox2
            if (ListBox2.SelectedItem != null)
            {
                // Get the selected decleration as a string
                string selectedItem = ListBox2.SelectedItem.ToString();

                // Add the selected decleration to ListBox1
                ListBox1.Items.Add(selectedItem);

                // Remove the selected decleration from ListBox2
                ListBox2.Items.Remove(selectedItem);
            }
        }

        private void Button_AddNewUsing_Click(object sender, EventArgs e)
        {
            // Add the text from TextBox_AddNew to ListBox1
            ListBox1.Items.Add(TextBox_AddNew.Text);

            // Save the updated items
            SaveItems();
        }

        private void Button_RemoveUsing_Click(object sender, EventArgs e)
        {
            // Check if an decleration is selected in ListBox1
            if (ListBox1.SelectedItem != null)
            {
                // Remove the selected decleration from ListBox1
                ListBox1.Items.Remove(ListBox1.SelectedItem);

                // Save the updated items
                SaveItems();
            }
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            // Iterate through each item in ListBox2
            foreach (object? item in ListBox2.Items)
            {
                // Add each item as a string to SnippetGenerator.UsingsList
                SnippetGenerator.UsingsList.Add(item.ToString());
            }

            // Close the form
            Close();
        }

        private void TextBox_AddNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.IsLetterOrDotNoSpace(e);
        }

        private void SaveItems()
        {
            // Create a new list to store the items
            List<string> list = new();

            // Iterate through each decleration in ListBox1
            foreach (object? item in ListBox1.Items)
            {
                // Convert the decleration to string and add it to the list
                list.Add(item.ToString());
            }

            // Save the list using the SaveList method
            SaveLoad.SaveList(_listTag, list);
        }
    }
}