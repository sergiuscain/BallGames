using BallGames.Common;

namespace BilliardBalls_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Ball ball = new BilliardBall(e.X, e.Y, this);
            ball.SetColor(Color.White);
            ball.SetDirection(5, 5);
            ball.Show();
            ball.StartMove();
        }
    }
}
