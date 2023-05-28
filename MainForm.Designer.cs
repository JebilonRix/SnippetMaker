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
            label2 = new Label();
            TextBox_SnippetShortcut = new TextBox();
            label3 = new Label();
            TextBox_SnippetName = new TextBox();
            ComboBox_Language = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            authorNameToolStripMenuItem = new ToolStripMenuItem();
            button5 = new Button();
            button6 = new Button();
            addUsingImportToolStripMenuItem = new ToolStripMenuItem();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Language";
            // 
            // TextBox_SnippetShortcut
            // 
            TextBox_SnippetShortcut.Location = new Point(132, 116);
            TextBox_SnippetShortcut.Name = "TextBox_SnippetShortcut";
            TextBox_SnippetShortcut.Size = new Size(240, 23);
            TextBox_SnippetShortcut.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 0;
            label3.Text = "Snippet Name *";
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
            ComboBox_Language.Items.AddRange(new object[] { "csharp", "cpp" });
            ComboBox_Language.Location = new Point(131, 40);
            ComboBox_Language.Name = "ComboBox_Language";
            ComboBox_Language.Size = new Size(242, 23);
            ComboBox_Language.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 9;
            label4.Text = "Snippet Shortcut *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 156);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Code *";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 282);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Sorround With";
            checkBox1.UseVisualStyleBackColor = true;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { addUsingImportToolStripMenuItem, authorNameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(438, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // authorNameToolStripMenuItem
            // 
            authorNameToolStripMenuItem.Name = "authorNameToolStripMenuItem";
            authorNameToolStripMenuItem.Size = new Size(74, 20);
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
            button6.Size = new Size(90, 23);
            button6.TabIndex = 22;
            button6.Text = "Add Field";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_AddField_Click;
            // 
            // addUsingImportToolStripMenuItem
            // 
            addUsingImportToolStripMenuItem.Name = "addUsingImportToolStripMenuItem";
            addUsingImportToolStripMenuItem.Size = new Size(115, 20);
            addUsingImportToolStripMenuItem.Text = "Add Using/Import";
            addUsingImportToolStripMenuItem.Click += UsingImportToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(438, 459);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ComboBox_Language);
            Controls.Add(label3);
            Controls.Add(TextBox_SnippetName);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox TextBox_SnippetShortcut;
        private Label label3;
        private TextBox TextBox_SnippetName;
        private ComboBox ComboBox_Language;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem authorNameToolStripMenuItem;
        private Button button5;
        private Button button6;
        private ToolStripMenuItem addUsingImportToolStripMenuItem;
    }
}