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
            if (centerX < 0 || centerX+radius+radius > form.Width)
            {
                vX = -vX;
            }
            if (centerY < 0 || centerY+radius +radius +radius> form.Height)
            {
                vY = -vY;
            }
            
                base.NextPosition();
            
        }
    }
}
