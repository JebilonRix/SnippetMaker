namespace SnippetMaker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button_Generate = new Button();
            TextBox_Code = new RichTextBox();
            Label_Language = new Label();
            TextBox_SnippetShortcut = new TextBox();
            Label_SnippetName = new Label();
            TextBox_SnippetName = new TextBox();
            ComboBox_Language = new ComboBox();
            Label_SnippetShortcut = new Label();
            Label_Code = new Label();
            Button_AddEnd = new Button();
            MenuStrip = new MenuStrip();
            AddUsingImportToolStripMenuItem = new ToolStripMenuItem();
            AuthorNameToolStripMenuItem = new ToolStripMenuItem();
            Button_AddSorround = new Button();
            Button_AddDecleration = new Button();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Generate
            // 
            Button_Generate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Generate.Location = new Point(131, 343);
            Button_Generate.Name = "Button_Generate";
            Button_Generate.Size = new Size(241, 33);
            Button_Generate.TabIndex = 9;
            Button_Generate.Text = "Generate";
            Button_Generate.UseVisualStyleBackColor = true;
            Button_Generate.Click += Button_Generate_Click;
            // 
            // TextBox_Code
            // 
            TextBox_Code.Location = new Point(132, 152);
            TextBox_Code.Name = "TextBox_Code";
            TextBox_Code.Size = new Size(241, 185);
            TextBox_Code.TabIndex = 2;
            TextBox_Code.Text = "";
            // 
            // Label_Language
            // 
            Label_Language.AutoSize = true;
            Label_Language.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Language.Location = new Point(12, 40);
            Label_Language.Name = "Label_Language";
            Label_Language.Size = new Size(60, 15);
            Label_Language.TabIndex = 5;
            Label_Language.Text = "Language";
            // 
            // TextBox_SnippetShortcut
            // 
            TextBox_SnippetShortcut.Location = new Point(132, 116);
            TextBox_SnippetShortcut.Name = "TextBox_SnippetShortcut";
            TextBox_SnippetShortcut.Size = new Size(240, 23);
            TextBox_SnippetShortcut.TabIndex = 1;
            // 
            // Label_SnippetName
            // 
            Label_SnippetName.AutoSize = true;
            Label_SnippetName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_SnippetName.Location = new Point(12, 76);
            Label_SnippetName.Name = "Label_SnippetName";
            Label_SnippetName.Size = new Size(86, 15);
            Label_SnippetName.TabIndex = 0;
            Label_SnippetName.Text = "Snippet Name";
            // 
            // TextBox_SnippetName
            // 
            TextBox_SnippetName.Location = new Point(132, 76);
            TextBox_SnippetName.Name = "TextBox_SnippetName";
            TextBox_SnippetName.Size = new Size(240, 23);
            TextBox_SnippetName.TabIndex = 0;
            // 
            // ComboBox_Language
            // 
            ComboBox_Language.FormattingEnabled = true;
            ComboBox_Language.Items.AddRange(new object[] { "C#", "C++", "Visual Basic", "JavaScript", "TypeScript", "Python", "XML", "CSS", "HTML" });
            ComboBox_Language.Location = new Point(131, 40);
            ComboBox_Language.Name = "ComboBox_Language";
            ComboBox_Language.Size = new Size(242, 23);
            ComboBox_Language.TabIndex = 5;
            // 
            // Label_SnippetShortcut
            // 
            Label_SnippetShortcut.AutoSize = true;
            Label_SnippetShortcut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_SnippetShortcut.Location = new Point(12, 116);
            Label_SnippetShortcut.Name = "Label_SnippetShortcut";
            Label_SnippetShortcut.Size = new Size(102, 15);
            Label_SnippetShortcut.TabIndex = 9;
            Label_SnippetShortcut.Text = "Snippet Shortcut";
            // 
            // Label_Code
            // 
            Label_Code.AutoSize = true;
            Label_Code.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Code.Location = new Point(12, 156);
            Label_Code.Name = "Label_Code";
            Label_Code.Size = new Size(35, 15);
            Label_Code.TabIndex = 10;
            Label_Code.Text = "Code";
            // 
            // Button_AddEnd
            // 
            Button_AddEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_AddEnd.Location = new Point(12, 196);
            Button_AddEnd.Name = "Button_AddEnd";
            Button_AddEnd.Size = new Size(90, 23);
            Button_AddEnd.TabIndex = 19;
            Button_AddEnd.Text = "Add End";
            Button_AddEnd.UseVisualStyleBackColor = true;
            Button_AddEnd.Click += Button_AddEnd_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.NavajoWhite;
            MenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MenuStrip.Items.AddRange(new ToolStripItem[] { AddUsingImportToolStripMenuItem, AuthorNameToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(401, 24);
            MenuStrip.TabIndex = 20;
            MenuStrip.Text = "MenuStrip";
            // 
            // AddUsingImportToolStripMenuItem
            // 
            AddUsingImportToolStripMenuItem.Name = "AddUsingImportToolStripMenuItem";
            AddUsingImportToolStripMenuItem.Size = new Size(119, 20);
            AddUsingImportToolStripMenuItem.Text = "Add Using/Import";
            AddUsingImportToolStripMenuItem.Click += UsingImportToolStripMenuItem_Click;
            // 
            // AuthorNameToolStripMenuItem
            // 
            AuthorNameToolStripMenuItem.Name = "AuthorNameToolStripMenuItem";
            AuthorNameToolStripMenuItem.Size = new Size(79, 20);
            AuthorNameToolStripMenuItem.Text = "Extra Infos";
            AuthorNameToolStripMenuItem.Click += ExtrasToolStripMenuItem_Click;
            // 
            // Button_AddSorround
            // 
            Button_AddSorround.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_AddSorround.Location = new Point(12, 225);
            Button_AddSorround.Name = "Button_AddSorround";
            Button_AddSorround.Size = new Size(90, 38);
            Button_AddSorround.TabIndex = 21;
            Button_AddSorround.Text = "Add Sorround";
            Button_AddSorround.UseVisualStyleBackColor = true;
            Button_AddSorround.Click += Button_AddSelected_Click;
            // 
            // Button_AddDecleration
            // 
            Button_AddDecleration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_AddDecleration.Location = new Point(12, 269);
            Button_AddDecleration.Name = "Button_AddDecleration";
            Button_AddDecleration.Size = new Size(90, 41);
            Button_AddDecleration.TabIndex = 22;
            Button_AddDecleration.Text = "Add Declaration";
            Button_AddDecleration.UseVisualStyleBackColor = true;
            Button_AddDecleration.Click += Button_AddDecleration_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(401, 392);
            Controls.Add(Button_AddDecleration);
            Controls.Add(Button_AddSorround);
            Controls.Add(Button_AddEnd);
            Controls.Add(Label_Code);
            Controls.Add(Label_SnippetShortcut);
            Controls.Add(ComboBox_Language);
            Controls.Add(Label_SnippetName);
            Controls.Add(TextBox_SnippetName);
            Controls.Add(Label_Language);
            Controls.Add(TextBox_SnippetShortcut);
            Controls.Add(TextBox_Code);
            Controls.Add(Button_Generate);
            Controls.Add(MenuStrip);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = MenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snippet Generator";
            Load += MainForm_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_AddDecleration;
        private Button Button_AddEnd;
        private Button Button_AddSorround;
        private Button Button_Generate;
        private ComboBox ComboBox_Language;
        private Label Label_Code;
        private Label Label_Language;
        private Label Label_SnippetName;
        private Label Label_SnippetShortcut;
        private MenuStrip MenuStrip;
        private RichTextBox TextBox_Code;
        private TextBox TextBox_SnippetName;
        private TextBox TextBox_SnippetShortcut;
        private ToolStripMenuItem AddUsingImportToolStripMenuItem;
        private ToolStripMenuItem AuthorNameToolStripMenuItem;
    }
}