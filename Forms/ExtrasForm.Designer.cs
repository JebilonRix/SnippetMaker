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
            label1 = new Label();
            TextBox_AuthorName = new TextBox();
            TextBox_HelpUrl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Button_Confirm = new Button();
            TextBox_Description = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Author Name";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Help Url";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // Button_Confirm
            // 
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
            ClientSize = new Size(418, 239);
            Controls.Add(TextBox_Description);
            Controls.Add(Button_Confirm);
            Controls.Add(label3);
            Controls.Add(TextBox_HelpUrl);
            Controls.Add(label2);
            Controls.Add(TextBox_AuthorName);
            Controls.Add(label1);
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

        private Label label1;
        private TextBox TextBox_AuthorName;
        private TextBox TextBox_HelpUrl;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button Button_Confirm;
        private RichTextBox TextBox_Description;
    }
}