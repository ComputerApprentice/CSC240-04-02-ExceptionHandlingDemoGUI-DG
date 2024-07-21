namespace CSC240_04_02_ExceptionHandlingDemoGUI_DG
{
    partial class Form1
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
            UxNumber1TextBox = new TextBox();
            UxIntegerEntry = new Label();
            UxIntegerButton = new Button();
            SuspendLayout();
            // 
            // UxNumber1TextBox
            // 
            UxNumber1TextBox.Location = new Point(113, 145);
            UxNumber1TextBox.Name = "UxNumber1TextBox";
            UxNumber1TextBox.Size = new Size(72, 23);
            UxNumber1TextBox.TabIndex = 0;
            UxNumber1TextBox.TextChanged += textBox1_TextChanged;
            // 
            // UxIntegerEntry
            // 
            UxIntegerEntry.AutoSize = true;
            UxIntegerEntry.Location = new Point(103, 80);
            UxIntegerEntry.Name = "UxIntegerEntry";
            UxIntegerEntry.Size = new Size(93, 15);
            UxIntegerEntry.TabIndex = 1;
            UxIntegerEntry.Text = "Enter an integer:";
            UxIntegerEntry.Click += label1_Click;
            // 
            // UxIntegerButton
            // 
            UxIntegerButton.Location = new Point(87, 214);
            UxIntegerButton.Name = "UxIntegerButton";
            UxIntegerButton.Size = new Size(131, 25);
            UxIntegerButton.TabIndex = 2;
            UxIntegerButton.Text = "Check number";
            UxIntegerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 307);
            Controls.Add(UxIntegerButton);
            Controls.Add(UxIntegerEntry);
            Controls.Add(UxNumber1TextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UxNumber1TextBox;
        private Label UxIntegerEntry;
        private Button UxIntegerButton;
    }
}
