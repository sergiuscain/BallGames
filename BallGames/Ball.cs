using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BallGames.Common
{
    internal class Ball
    {
        private int X { get; set; } = 0;
        private int Y { get; set; } = 0;
        private int vX { get; set; } = 5;
        private int vY { get; set; } = 5;
        private int width { get; set; } = 40;
        private int height { get; set; } = 40;
        private Form form;
        private Graphics graphics;
        private Timer timer;

        public Ball(int x, int y, Form form)
        {
            X = x;
            Y = y;
            this.form = form;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Step();
        }

        public void NextPosition()
        {
            X += vX;
            Y += vY;
        }
        public void Clear()
        {
            var clearGraphics = form.CreateGraphics();
            var brush = new SolidBrush(form.BackColor);
            clearGraphics.FillRectangle(brush, X, Y, width, height);
        }
        public void Show()
        {
            graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(X, Y, width, height);
            graphics.FillEllipse(brush, rectangle);
        }

        internal void Step()
        {
            Clear();
            NextPosition();
            Show();
        }
        internal void Start()
        {
            timer.Start();
        }
        internal void Stop()
        {
            timer.Stop();
        }
    }
}

// Ball class represents a ball in the game. It has properties for position, speed, and direction.