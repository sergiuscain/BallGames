﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BallGames.Common
{
    public class BirdBall : Ball
    {
        public int countBird { get; protected set; } = 3;

        public float g { get; protected set; } = 0.2f;
        public float elastic { get; protected set; } = 0.5f;
        public float startX { get; protected set; }
        public float startY { get; protected set; }
        public BirdBall(int x, int y, Form form) : base(x, y, form)
        {
            SetColor(Color.Red);
            SetRadius(40);
            startX = centerX;
            startY = centerY;
        }
        protected override void NextPosition()
        {
            base.NextPosition();
            if (centerY >= form.Height-radius*2)
            {
                vY = -vY;
                vY *= elastic;
                vX *= elastic;
                centerY = form.Height-radius*2;
            }
            if (centerX >= form.Width-radius || centerX < -radius)
            {
                vX = -vX;
            }
            vY += g;
            if (Math.Abs(vX) < 0.2 && Math.Abs(vY) < 0.2)
            { 
                StopMove(); 
                if (countBird-1 > 0)
                {
                centerX = startX;
                centerY = startY;
                Show();
                active = true;
                    countBird--;
                    MessageBox.Show($"Осталось {countBird} птиц");
                }
                else
                {
                    MessageBox.Show("Птицы закончились!\n Ты проиграл");
                    form.Close();
                }
            }
        }
        public void SetCountBird(int countBird)
        {
            this.countBird = countBird;
        }

        public bool Concerns(Ball other)
        {
            var dX = centerX - other.centerX;
            var dY = centerY - other.centerY;
            return (dX * dX + dY * dY) <= Math.Pow(radius + other.radius,2); 
        }
    }
}
