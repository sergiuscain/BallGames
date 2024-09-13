using BallGames.Common;

namespace BallGames
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<Ball> balls = new List<Ball>();
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {

                Ball ball = new Ball(r.Next(0,this.Height), r.Next(0,this.Width), this);
                balls.Add(ball);
                ball.Show();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (balls.Count > 0)
            {
                foreach (Ball ball in balls)
                {
                    ball.Clear();
                }
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (balls.Count > 0)
            {
                foreach (Ball ball in balls)
                {
                    ball.Move();
                }
            }
        }
    }
}
 