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
        public BirdBall(int x, int y, Form form) : base(x, y, form)
        {

        }
        protected override void NextPosition()
        {
            vY += g;
            base.NextPosition();
            if (centerY >= form.Height-60)
            {
                StopMove();
            }
        }
    }
}
