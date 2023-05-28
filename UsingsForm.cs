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

            //Sorts the list.
            usingList.Sort();

            // Iterate through each item in the loaded list
            foreach (string item in usingList)
            {
                // Add each item to ListBox1
                ListBox1.Items.Add(item);
            }
        }

        private void Button_ToLeft_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in ListBox1
            if (ListBox1.SelectedItem != null)
            {
                // Get the selected item as a string
                string selectedItem = ListBox1.SelectedItem.ToString();

                // Add the selected item to ListBox2
                ListBox2.Items.Add(selectedItem);

                // Remove the selected item from ListBox1
                ListBox1.Items.Remove(selectedItem);
            }
        }

        private void Button_ToRight_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in ListBox2
            if (ListBox2.SelectedItem != null)
            {
                // Get the selected item as a string
                string selectedItem = ListBox2.SelectedItem.ToString();

                // Add the selected item to ListBox1
                ListBox1.Items.Add(selectedItem);

                // Remove the selected item from ListBox2
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
            // Check if an item is selected in ListBox1
            if (ListBox1.SelectedItem != null)
            {
                // Remove the selected item from ListBox1
                ListBox1.Items.Remove(ListBox1.SelectedItem);

                // Save the updated items
                SaveItems();
            }
        }

        private void TextBox_AddNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.IsLetterOrDotNoSpace(e);
        }

        private void SaveItems()
        {
            // Create a new list to store the items
            List<string> list = new List<string>();

            // Iterate through each item in ListBox1
            foreach (object? item in ListBox1.Items)
            {
                // Convert the item to string and add it to the list
                list.Add(item.ToString());
            }

            // Save the list using the SaveList method
            SaveLoad.SaveList(_listTag, list);
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            foreach (object? item in ListBox2.Items)
            {
                SnippetGenerator.UsingsList.Add(item.ToString());
            }

            //MessageBox.Show(SnippetGenerator.UsingsList.Count.ToString());
        }
    }
}