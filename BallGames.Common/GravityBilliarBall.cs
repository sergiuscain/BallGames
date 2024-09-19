using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGames.Common
{
    public class GravityBilliarBall : BilliardBall
    {
        private float g = 1f;
        public GravityBilliarBall(int x, int y, Form form) : base(x, y, form)
        {
        }
        protected override void NextPosition()
        {
            base.NextPosition();
            vY += g;
        }
        public void ApplyGravity()
        {
            vY += g;
        }
        public void StopGravity()
        {
            vY = 0;
        }
        public void ChangeGravity(float newGravity)
        {
            g = newGravity;
        }
        
    }
}
