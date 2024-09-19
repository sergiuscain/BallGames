using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGames.Common
{
    public class BirdBall : Ball
    {
        public float g { get; protected set; } = 0.5f;
        public BirdBall(int x, int y, Form form) : base(x, y, form)
        {
            SetColor(Color.Red);
            SetRadius(40);
        }
        protected override void NextPosition()
        {
            vY += g;
            base.NextPosition();
            if (centerY >= form.Height-radius)
            {
                vY = -vY;
            }
            if (centerY >= form.Height - (radius-10))
            {
                StopMove();
                centerY = form.Height-radius*2;
                Show();
            }
        }
    }
}
