using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGames.Common
{
    public class BirdBall : Ball
    {
        public float g { get; protected set; } = 0.2f;
        public float elastic { get; protected set; } = 0.2f;
        public BirdBall(int x, int y, Form form) : base(x, y, form)
        {
            SetColor(Color.Red);
            SetRadius(40);
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
        }
    }
}
