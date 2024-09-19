using BallGames.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace FireWorkAndAngryBirds_WinForms
{
    public partial class AngryBirds_Form : Form
    {
        BirdBall bird;
        PigBall pig;
        Timer timer = new Timer();
        private int score = 0;
        private float kX = 25;
        private float kY = 13;
        private float maxX = 15;
        private float maxY = -19;
        public AngryBirds_Form()
        {
            InitializeComponent();
        }

        private void AngryBirds_Form_Load(object sender, EventArgs e)
        {
            timer.Tick += Timer_Tick;
            timer.Interval = 10;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (bird.IsCollision(pig.centerX,pig.centerY))
            {
                timer.Stop();
                score += 10;
                scoreLabel.Text = $"Score: {score}";
                pig = new PigBall(Width - 100, Height - 80, this);
                pig.Show();
            }
        }

        private void AngryBirds_Form_Shown(object sender, EventArgs e)
        {
            scoreLabel.Text = "0";
            birdCountLabel.Text = "0";
            bird = new BirdBall(0 + 50, Height - 80, this);
            bird.Show();
            pig = new PigBall(Width - 100, Height - 80, this);
            pig.Show();
            birdCountLabel.Text = $"{bird.countBird}";

        }

        private void AngryBirds_Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (bird.active == true)
            {
                birdCountLabel.Text = $"{bird.countBird-1}";
            float x = (e.X - bird.centerX)/kX;
            float y = (e.Y - bird.centerY) / kY;
            if (x > maxX)
                x = maxX;
            if (y < maxY)
                y = maxY;
            bird.SetDirection(x,y);
            bird.StartMove();
            timer.Start();
            bird.active = false;
            }
        }
    }
}
