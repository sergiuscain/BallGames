using Timer = System.Windows.Forms.Timer;

namespace BallGames.Common
{
    public class FireWorkBall : GravityBall
    {
        Random random = new Random();
        protected Timer delTimer;
        public FireWorkBall(float x, float y, Form form) : base(x, y, form)
        {
            vY = -random.Next(5,30);
            vX = random.Next(-10, 10);
            delTimer = new Timer();
            delTimer.Interval = random.Next(300, 800);
            delTimer.Tick += delTimer_Tick;
            delTimer.Start();
        }

        private void delTimer_Tick(object? sender, EventArgs e)
        {
            StopMove();
            Clear();
        }

    }
}
