using BallGames;
using BallGames.Common;

namespace BallGames
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<Ball> balls = new List<Ball>();
        int countHit = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            drawButton.Enabled = false;
            moveButton.Enabled = true;
            clearButton.Enabled = true;
            stopButton.Enabled = false;
            for (int i = 0; i < r.Next(7,20); i++)
            {

                Ball ball = new Ball(r.Next(0, this.Height), r.Next(0, this.Width), this);
                ball.SetSpeed(r.Next(1, 10));
                ball.SetDirection(r.Next(-5, 5), r.Next(-5, 5));
                ball.SetColor(ball.RandomCollor());
                ball.SetRadius(r.Next(4,40));
                ball.Show();
                balls.Add(ball);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            drawButton.Enabled = true;
            clearButton.Enabled = false;
            moveButton.Enabled = false;
            if (balls.Count > 0)
            {
                foreach (Ball ball in balls)
                {
                    ball.StopMove();
                    ball.Clear();
                }
                balls.Clear();
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true ;
            if (balls.Count > 0)
            {
                foreach (Ball ball in balls)
                {
                    ball.StartMove();
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Ball ball in balls)
            {
                if (ball.IsCollision(e.X, e.Y))
                {
                    if (ball.IsMoving())
                    {
                        countHit++;
                        ball.StopMove();
                    }
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            foreach(Ball ball in balls)
            {
                if (ball.IsMoving())
                {
                    ball.StopMove();
                }
            }
            MessageBox.Show($"Вы поймали:{countHit}");
            countHit = 0;
        }
    }
}
 