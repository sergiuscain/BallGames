namespace FireWork_WinForms
{
    partial class Test2_Form
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
            Fire_Button = new Button();
            SuspendLayout();
            // 
            // Fire_Button
            // 
            Fire_Button.Location = new Point(7, 7);
            Fire_Button.Name = "Fire_Button";
            Fire_Button.Size = new Size(81, 53);
            Fire_Button.TabIndex = 0;
            Fire_Button.Text = "Fire";
            Fire_Button.UseVisualStyleBackColor = true;
            Fire_Button.Click += Fire_Button_Click;
            // 
            // Test2_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(750, 819);
            Controls.Add(Fire_Button);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Test2_Form";
            Text = "Test2";
            ResumeLayout(false);
        }

        #endregion

        private Button Fire_Button;
    }
}