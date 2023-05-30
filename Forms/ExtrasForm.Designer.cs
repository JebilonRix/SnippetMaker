namespace SnippetMaker
{
    partial class ExtrasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_AuthorName = new Label();
            TextBox_AuthorName = new TextBox();
            TextBox_HelpUrl = new TextBox();
            Label_HelpUrl = new Label();
            Label_Description = new Label();
            Button_Confirm = new Button();
            TextBox_Description = new RichTextBox();
            SuspendLayout();
            // 
            // Label_AuthorName
            // 
            Label_AuthorName.AutoSize = true;
            Label_AuthorName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_AuthorName.Location = new Point(10, 20);
            Label_AuthorName.Name = "Label_AuthorName";
            Label_AuthorName.Size = new Size(82, 15);
            Label_AuthorName.TabIndex = 0;
            Label_AuthorName.Text = "Author Name";
            // 
            // TextBox_AuthorName
            // 
            TextBox_AuthorName.Location = new Point(100, 20);
            TextBox_AuthorName.Name = "TextBox_AuthorName";
            TextBox_AuthorName.Size = new Size(272, 23);
            TextBox_AuthorName.TabIndex = 1;
            // 
            // TextBox_HelpUrl
            // 
            TextBox_HelpUrl.Location = new Point(100, 60);
            TextBox_HelpUrl.Name = "TextBox_HelpUrl";
            TextBox_HelpUrl.Size = new Size(272, 23);
            TextBox_HelpUrl.TabIndex = 3;
            // 
            // Label_HelpUrl
            // 
            Label_HelpUrl.AutoSize = true;
            Label_HelpUrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_HelpUrl.Location = new Point(10, 60);
            Label_HelpUrl.Name = "Label_HelpUrl";
            Label_HelpUrl.Size = new Size(53, 15);
            Label_HelpUrl.TabIndex = 2;
            Label_HelpUrl.Text = "Help Url";
            // 
            // Label_Description
            // 
            Label_Description.AutoSize = true;
            Label_Description.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Description.Location = new Point(10, 100);
            Label_Description.Name = "Label_Description";
            Label_Description.Size = new Size(71, 15);
            Label_Description.TabIndex = 4;
            Label_Description.Text = "Description";
            // 
            // Button_Confirm
            // 
            Button_Confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Confirm.Location = new Point(100, 195);
            Button_Confirm.Name = "Button_Confirm";
            Button_Confirm.Size = new Size(272, 23);
            Button_Confirm.TabIndex = 6;
            Button_Confirm.Text = "Confirm";
            Button_Confirm.UseVisualStyleBackColor = true;
            Button_Confirm.Click += Button_Confirm_Click;
            // 
            // TextBox_Description
            // 
            TextBox_Description.Location = new Point(100, 100);
            TextBox_Description.Name = "TextBox_Description";
            TextBox_Description.Size = new Size(272, 76);
            TextBox_Description.TabIndex = 7;
            TextBox_Description.Text = "";
            // 
            // ExtrasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(418, 239);
            Controls.Add(TextBox_Description);
            Controls.Add(Button_Confirm);
            Controls.Add(Label_Description);
            Controls.Add(TextBox_HelpUrl);
            Controls.Add(Label_HelpUrl);
            Controls.Add(TextBox_AuthorName);
            Controls.Add(Label_AuthorName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExtrasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Extras";
            Load += ExtrasForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Confirm;
        private Label Label_AuthorName;
        private Label Label_HelpUrl;
        private Label Label_Description;
        private RichTextBox TextBox_Description;
        private TextBox TextBox_AuthorName;
        private TextBox TextBox_HelpUrl;
    }
}