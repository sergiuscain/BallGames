using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGames.Common
{
    public class BirdBall : Ball
    {
        public float g { get; protected set; }
        public BirdBall(int x, int y, Form form) : base(x, y, form)
        {

        }
        protected override void NextPosition()
        {
            base.NextPosition();
            vY += g;
        }
    }
}
