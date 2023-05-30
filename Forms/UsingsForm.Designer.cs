namespace SnippetMaker
{
    partial class UsingsForm
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
            Button_ToLeft = new Button();
            Button_ToRight = new Button();
            ListBox1 = new ListBox();
            ListBox2 = new ListBox();
            Button_Confirm = new Button();
            TextBox_AddNew = new TextBox();
            label1 = new Label();
            Button_AddNewUsing = new Button();
            Button_RemoveUsing = new Button();
            SuspendLayout();
            // 
            // Button_ToLeft
            // 
            Button_ToLeft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_ToLeft.Location = new Point(276, 66);
            Button_ToLeft.Name = "Button_ToLeft";
            Button_ToLeft.Size = new Size(40, 40);
            Button_ToLeft.TabIndex = 21;
            Button_ToLeft.Text = "<";
            Button_ToLeft.UseVisualStyleBackColor = true;
            Button_ToLeft.Click += Button_ToRight_Click;
            // 
            // Button_ToRight
            // 
            Button_ToRight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_ToRight.Location = new Point(276, 12);
            Button_ToRight.Name = "Button_ToRight";
            Button_ToRight.Size = new Size(40, 40);
            Button_ToRight.TabIndex = 20;
            Button_ToRight.Text = ">";
            Button_ToRight.UseVisualStyleBackColor = true;
            Button_ToRight.Click += Button_ToLeft_Click;
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(12, 12);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(245, 109);
            ListBox1.TabIndex = 19;
            // 
            // ListBox2
            // 
            ListBox2.FormattingEnabled = true;
            ListBox2.ItemHeight = 15;
            ListBox2.Location = new Point(333, 12);
            ListBox2.Name = "ListBox2";
            ListBox2.Size = new Size(245, 109);
            ListBox2.TabIndex = 23;
            // 
            // Button_Confirm
            // 
            Button_Confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Confirm.Location = new Point(333, 142);
            Button_Confirm.Name = "Button_Confirm";
            Button_Confirm.Size = new Size(245, 32);
            Button_Confirm.TabIndex = 24;
            Button_Confirm.Text = "Confirm Using/Import";
            Button_Confirm.UseVisualStyleBackColor = true;
            Button_Confirm.Click += Button_Confirm_Click;
            // 
            // TextBox_AddNew
            // 
            TextBox_AddNew.Location = new Point(12, 151);
            TextBox_AddNew.Name = "TextBox_AddNew";
            TextBox_AddNew.Size = new Size(192, 23);
            TextBox_AddNew.TabIndex = 25;
            TextBox_AddNew.KeyPress += TextBox_AddNew_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 26;
            label1.Text = "Add New Using/Import";
            // 
            // Button_AddNewUsing
            // 
            Button_AddNewUsing.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_AddNewUsing.Location = new Point(12, 180);
            Button_AddNewUsing.Name = "Button_AddNewUsing";
            Button_AddNewUsing.Size = new Size(75, 23);
            Button_AddNewUsing.TabIndex = 27;
            Button_AddNewUsing.Text = "Add";
            Button_AddNewUsing.UseVisualStyleBackColor = true;
            Button_AddNewUsing.Click += Button_AddNewUsing_Click;
            // 
            // Button_RemoveUsing
            // 
            Button_RemoveUsing.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_RemoveUsing.Location = new Point(129, 180);
            Button_RemoveUsing.Name = "Button_RemoveUsing";
            Button_RemoveUsing.Size = new Size(75, 23);
            Button_RemoveUsing.TabIndex = 28;
            Button_RemoveUsing.Text = "Remove";
            Button_RemoveUsing.UseVisualStyleBackColor = true;
            Button_RemoveUsing.Click += Button_RemoveUsing_Click;
            // 
            // UsingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(596, 215);
            Controls.Add(Button_RemoveUsing);
            Controls.Add(Button_AddNewUsing);
            Controls.Add(label1);
            Controls.Add(TextBox_AddNew);
            Controls.Add(Button_Confirm);
            Controls.Add(ListBox2);
            Controls.Add(Button_ToLeft);
            Controls.Add(Button_ToRight);
            Controls.Add(ListBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsingsForm";
            Load += UsingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_AddNewUsing;
        private Button Button_Confirm;
        private Button Button_RemoveUsing;
        private Button Button_ToLeft;
        private Button Button_ToRight;
        private Label label1;
        private ListBox ListBox1;
        private ListBox ListBox2;
        private TextBox TextBox_AddNew;
    }
}