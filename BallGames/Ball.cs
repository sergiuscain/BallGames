using System;
using System.Windows.Forms;

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

        public Ball(int x, int y, Form form)
        {
            X = x;
            Y = y;
            this.form = form;
        }
        public void NextPosition()
        {
            X += vX;
            Y += vY;
        }
        public void Clear()
        {
            graphics.Clear(form.BackColor);
        }
        public void Show()
        {
            graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(X, Y, width, height);
            graphics.FillEllipse(brush, rectangle);
        }

    }
}

// Ball class represents a ball in the game. It has properties for position, speed, and direction.