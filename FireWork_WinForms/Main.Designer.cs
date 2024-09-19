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
            Test2_Button = new Button();
            AngryBirds_Button = new Button();
            SuspendLayout();
            // 
            // test1_Button
            // 
            test1_Button.BackColor = Color.LightGreen;
            test1_Button.FlatStyle = FlatStyle.Flat;
            test1_Button.Location = new Point(21, 12);
            test1_Button.Name = "test1_Button";
            test1_Button.Size = new Size(125, 76);
            test1_Button.TabIndex = 0;
            test1_Button.Text = "Test1";
            test1_Button.UseVisualStyleBackColor = false;
            test1_Button.Click += test1_Button_Click;
            // 
            // Test2_Button
            // 
            Test2_Button.BackColor = Color.Turquoise;
            Test2_Button.FlatStyle = FlatStyle.Flat;
            Test2_Button.Location = new Point(188, 12);
            Test2_Button.Name = "Test2_Button";
            Test2_Button.Size = new Size(133, 76);
            Test2_Button.TabIndex = 1;
            Test2_Button.Text = "Test2-FireWork";
            Test2_Button.UseVisualStyleBackColor = false;
            Test2_Button.Click += Test2_Button_Click;
            // 
            // AngryBirds_Button
            // 
            AngryBirds_Button.BackColor = Color.DarkOrange;
            AngryBirds_Button.FlatStyle = FlatStyle.Flat;
            AngryBirds_Button.Location = new Point(352, 67);
            AngryBirds_Button.Name = "AngryBirds_Button";
            AngryBirds_Button.Size = new Size(163, 103);
            AngryBirds_Button.TabIndex = 2;
            AngryBirds_Button.Text = "AngryBirds";
            AngryBirds_Button.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(AngryBirds_Button);
            Controls.Add(Test2_Button);
            Controls.Add(test1_Button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button test1_Button;
        private Button Test2_Button;
        private Button AngryBirds_Button;
    }
}