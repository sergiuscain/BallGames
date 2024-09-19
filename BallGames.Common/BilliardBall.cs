using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGames.Common
{
    public class BilliardBall:Ball
    {
        public BilliardBall(int x, int y, Form form) : base(x, y, form)
        {
            
        }

        protected override void NextPosition()
        {
            if (centerX-radius <= 0 || centerX+radius >= form.Width)
            {
                vX = -vX;
            }
            if (centerY-radius <= 0 || centerY+radius >= form.Height)
            {
                vY = -vY;
            }
            
                base.NextPosition();
            
        }
    }
}
