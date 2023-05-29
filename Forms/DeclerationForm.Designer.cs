namespace SnippetMaker.Forms
{
    partial class DeclerationForm
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
            Label_ID = new Label();
            TextBox_ID = new TextBox();
            TextBox_ToolTip = new TextBox();
            Label_ToolTip = new Label();
            TextBox_Default = new TextBox();
            Label_Default = new Label();
            Label_Function = new Label();
            Button_Confirm = new Button();
            ComboBox_Function = new ComboBox();
            SuspendLayout();
            // 
            // Label_ID
            // 
            Label_ID.AutoSize = true;
            Label_ID.Location = new Point(15, 10);
            Label_ID.Name = "Label_ID";
            Label_ID.Size = new Size(18, 15);
            Label_ID.TabIndex = 0;
            Label_ID.Text = "ID";
            // 
            // TextBox_ID
            // 
            TextBox_ID.Location = new Point(75, 10);
            TextBox_ID.Name = "TextBox_ID";
            TextBox_ID.Size = new Size(100, 23);
            TextBox_ID.TabIndex = 1;
            // 
            // TextBox_ToolTip
            // 
            TextBox_ToolTip.Location = new Point(75, 50);
            TextBox_ToolTip.Name = "TextBox_ToolTip";
            TextBox_ToolTip.Size = new Size(100, 23);
            TextBox_ToolTip.TabIndex = 3;
            // 
            // Label_ToolTip
            // 
            Label_ToolTip.AutoSize = true;
            Label_ToolTip.Location = new Point(15, 50);
            Label_ToolTip.Name = "Label_ToolTip";
            Label_ToolTip.Size = new Size(45, 15);
            Label_ToolTip.TabIndex = 2;
            Label_ToolTip.Text = "ToolTip";
            // 
            // TextBox_Default
            // 
            TextBox_Default.Location = new Point(75, 90);
            TextBox_Default.Name = "TextBox_Default";
            TextBox_Default.Size = new Size(100, 23);
            TextBox_Default.TabIndex = 5;
            // 
            // Label_Default
            // 
            Label_Default.AutoSize = true;
            Label_Default.Location = new Point(15, 90);
            Label_Default.Name = "Label_Default";
            Label_Default.Size = new Size(45, 15);
            Label_Default.TabIndex = 4;
            Label_Default.Text = "Default";
            // 
            // Label_Function
            // 
            Label_Function.AutoSize = true;
            Label_Function.Location = new Point(15, 130);
            Label_Function.Name = "Label_Function";
            Label_Function.Size = new Size(54, 15);
            Label_Function.TabIndex = 6;
            Label_Function.Text = "Function";
            // 
            // Button_Confirm
            // 
            Button_Confirm.Location = new Point(75, 164);
            Button_Confirm.Name = "Button_Confirm";
            Button_Confirm.Size = new Size(100, 23);
            Button_Confirm.TabIndex = 8;
            Button_Confirm.Text = "Confirm";
            Button_Confirm.UseVisualStyleBackColor = true;
            Button_Confirm.Click += Button_Confirm_Click;
            // 
            // ComboBox_Function
            // 
            ComboBox_Function.FormattingEnabled = true;
            ComboBox_Function.Items.AddRange(new object[] { "ClassName()" });
            ComboBox_Function.Location = new Point(75, 127);
            ComboBox_Function.Name = "ComboBox_Function";
            ComboBox_Function.Size = new Size(100, 23);
            ComboBox_Function.TabIndex = 9;
            // 
            // DeclerationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 208);
            Controls.Add(ComboBox_Function);
            Controls.Add(Button_Confirm);
            Controls.Add(Label_Function);
            Controls.Add(TextBox_Default);
            Controls.Add(Label_Default);
            Controls.Add(TextBox_ToolTip);
            Controls.Add(Label_ToolTip);
            Controls.Add(TextBox_ID);
            Controls.Add(Label_ID);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeclerationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Decleration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_ID;
        private TextBox TextBox_ID;
        private TextBox TextBox_ToolTip;
        private Label Label_ToolTip;
        private TextBox TextBox_Default;
        private Label Label_Default;
        private Label Label_Function;
        private Button Button_Confirm;
        private ComboBox ComboBox_Function;
    }
}