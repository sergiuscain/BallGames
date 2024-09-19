using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGames.Common
{
    public class PigBall : BilliardBall
    {
        public PigBall(int x, int y, Form form) : base(x, y, form)
        {
            SetColor(Color.Green);
            SetRadius(50);
        }
    }
}
