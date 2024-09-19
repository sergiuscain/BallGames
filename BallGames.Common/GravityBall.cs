using Timer = System.Windows.Forms.Timer;

namespace BallGames.Common
{
    public class GravityBall : Ball
    {
        private float g = 0.5f;
        public Timer actionTimer = new Timer();

        public GravityBall(float x, float y, Form form) : base(x, y, form)
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
