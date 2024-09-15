namespace BallGames
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
            drawButton = new Button();
            clearButton = new Button();
            moveButton = new Button();
            stopButton = new Button();
            SuspendLayout();
            // 
            // drawButton
            // 
            drawButton.Location = new Point(31, 13);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(105, 39);
            drawButton.TabIndex = 0;
            drawButton.Text = "Draw";
            drawButton.UseVisualStyleBackColor = true;
            drawButton.Click += drawButton_Click;
            // 
            // clearButton
            // 
            clearButton.Enabled = false;
            clearButton.Location = new Point(183, 21);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // moveButton
            // 
            moveButton.Enabled = false;
            moveButton.Location = new Point(280, 21);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(75, 23);
            moveButton.TabIndex = 2;
            moveButton.Text = "Move";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += MoveButton_Click;
            // 
            // stopButton
            // 
            stopButton.Enabled = false;
            stopButton.Location = new Point(389, 21);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 23);
            stopButton.TabIndex = 3;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += StopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stopButton);
            Controls.Add(moveButton);
            Controls.Add(clearButton);
            Controls.Add(drawButton);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button drawButton;
        private Button clearButton;
        private Button moveButton;
        private Button stopButton;
    }
}
