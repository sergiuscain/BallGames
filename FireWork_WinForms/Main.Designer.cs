namespace FireWork_WinForms
{
    partial class Main
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
            test1_Button = new Button();
            SuspendLayout();
            // 
            // test1_Button
            // 
            test1_Button.Location = new Point(21, 12);
            test1_Button.Name = "test1_Button";
            test1_Button.Size = new Size(125, 76);
            test1_Button.TabIndex = 0;
            test1_Button.Text = "Test1";
            test1_Button.UseVisualStyleBackColor = true;
            test1_Button.Click += test1_Button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(test1_Button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button test1_Button;
    }
}