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
            button1 = new Button();
            TextBox_Code = new RichTextBox();
            Label_Language = new Label();
            TextBox_SnippetShortcut = new TextBox();
            Label_SnippetName = new Label();
            TextBox_SnippetName = new TextBox();
            ComboBox_Language = new ComboBox();
            Label_SnippetShortcut = new Label();
            Label_Code = new Label();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            addUsingImportToolStripMenuItem = new ToolStripMenuItem();
            authorNameToolStripMenuItem = new ToolStripMenuItem();
            button5 = new Button();
            button6 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(131, 343);
            button1.Name = "button1";
            button1.Size = new Size(241, 33);
            button1.TabIndex = 9;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Generate_Click;
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
            ComboBox_Language.Items.AddRange(new object[] { "csharp", "cpp", "JavaScript", "TypeScript", "VB", "css", "html", "XML", "Python" });
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
            // button4
            // 
            button4.Location = new Point(12, 194);
            button4.Name = "button4";
            button4.Size = new Size(90, 23);
            button4.TabIndex = 19;
            button4.Text = "Add End";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_AddEnd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.NavajoWhite;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addUsingImportToolStripMenuItem, authorNameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(401, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // addUsingImportToolStripMenuItem
            // 
            addUsingImportToolStripMenuItem.Name = "addUsingImportToolStripMenuItem";
            addUsingImportToolStripMenuItem.Size = new Size(119, 20);
            addUsingImportToolStripMenuItem.Text = "Add Using/Import";
            addUsingImportToolStripMenuItem.Click += UsingImportToolStripMenuItem_Click;
            // 
            // authorNameToolStripMenuItem
            // 
            authorNameToolStripMenuItem.Name = "authorNameToolStripMenuItem";
            authorNameToolStripMenuItem.Size = new Size(79, 20);
            authorNameToolStripMenuItem.Text = "Extra Infos";
            authorNameToolStripMenuItem.Click += ExtrasToolStripMenuItem_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 223);
            button5.Name = "button5";
            button5.Size = new Size(90, 23);
            button5.TabIndex = 21;
            button5.Text = "Add Sorround";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_AddSelected_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 252);
            button6.Name = "button6";
            button6.Size = new Size(90, 41);
            button6.TabIndex = 22;
            button6.Text = "Add Declaration";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_AddDecleration_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(401, 392);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(Label_Code);
            Controls.Add(Label_SnippetShortcut);
            Controls.Add(ComboBox_Language);
            Controls.Add(Label_SnippetName);
            Controls.Add(TextBox_SnippetName);
            Controls.Add(Label_Language);
            Controls.Add(TextBox_SnippetShortcut);
            Controls.Add(TextBox_Code);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox TextBox_Code;
        private Label Label_Language;
        private TextBox TextBox_SnippetShortcut;
        private Label Label_SnippetName;
        private TextBox TextBox_SnippetName;
        private ComboBox ComboBox_Language;
        private Label Label_SnippetShortcut;
        private Label Label_Code;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem authorNameToolStripMenuItem;
        private Button button5;
        private Button button6;
        private ToolStripMenuItem addUsingImportToolStripMenuItem;
    }
}