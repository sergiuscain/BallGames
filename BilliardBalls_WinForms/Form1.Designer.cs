namespace BilliardBalls_WinForms
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
            button1 = new Button();
            leftRedLabel = new Label();
            rightRedLabel = new Label();
            leftBlueLabel = new Label();
            rightBlueLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(299, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // leftRedLabel
            // 
            leftRedLabel.AutoSize = true;
            leftRedLabel.BackColor = SystemColors.ActiveCaption;
            leftRedLabel.Location = new Point(60, 10);
            leftRedLabel.Name = "leftRedLabel";
            leftRedLabel.Size = new Size(38, 15);
            leftRedLabel.TabIndex = 1;
            leftRedLabel.Text = "label1";
            // 
            // rightRedLabel
            // 
            rightRedLabel.AutoSize = true;
            rightRedLabel.BackColor = SystemColors.ActiveCaption;
            rightRedLabel.Location = new Point(697, 6);
            rightRedLabel.Name = "rightRedLabel";
            rightRedLabel.Size = new Size(38, 15);
            rightRedLabel.TabIndex = 2;
            rightRedLabel.Text = "label2";
            // 
            // leftBlueLabel
            // 
            leftBlueLabel.AutoSize = true;
            leftBlueLabel.BackColor = SystemColors.ActiveCaption;
            leftBlueLabel.Location = new Point(60, 25);
            leftBlueLabel.Name = "leftBlueLabel";
            leftBlueLabel.Size = new Size(38, 15);
            leftBlueLabel.TabIndex = 3;
            leftBlueLabel.Text = "label3";
            // 
            // rightBlueLabel
            // 
            rightBlueLabel.AutoSize = true;
            rightBlueLabel.BackColor = SystemColors.ActiveCaption;
            rightBlueLabel.Location = new Point(697, 24);
            rightBlueLabel.Name = "rightBlueLabel";
            rightBlueLabel.Size = new Size(38, 15);
            rightBlueLabel.TabIndex = 4;
            rightBlueLabel.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "LeftRed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(633, 6);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "RightRed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(4, 25);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "LeftBlue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(633, 21);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "RightBlue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(804, 282);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rightBlueLabel);
            Controls.Add(leftBlueLabel);
            Controls.Add(rightRedLabel);
            Controls.Add(leftRedLabel);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label leftRedLabel;
        private Label rightRedLabel;
        private Label leftBlueLabel;
        private Label rightBlueLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
