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
        private int radius { get; set; } = 40;
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
            clearGraphics.FillRectangle(brush, X, Y, radius, radius);
        }
        public void Show()
        {
            graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(X, Y, radius, radius);
            graphics.FillEllipse(brush, rectangle);
        }

        internal void Step()
        {
            Clear();
            NextPosition();
            Show();
        }
        internal void StartMove()
        {
            timer.Start();
        }
        internal void StopMove()
        {
            timer.Stop();
        }

        internal void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        internal void SetSpeed(int speed)
        {
            timer.Interval = speed;
        }
        internal void SetDirection(int vX, int vY)
        {
            this.vX = vX;
            this.vY = vY;
        }

        internal bool IsCollision(int x, int y)
        {
            return (x - X) * (x - X) + (y - Y) * (y - Y) <= radius*radius;
        }
        internal void ReverseDirection()
        {
            vX = -vX;
            vY = -vY;
        }
        internal bool IsMoving()
        {
            return timer.Enabled;
        }
    }
}

// Ball class represents a ball in the game. It has properties for position, speed, and direction.