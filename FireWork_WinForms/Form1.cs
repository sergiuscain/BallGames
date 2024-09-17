using BallGames.Common;

namespace FireWork_WinForms
{
    public partial class Form1 : Form
    {
        private float startPosition = 0;
        private float endPosition = 0;
        int x;
        int y;
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPosition = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endPosition = e.Y;
            var firework = new GravityBall(e.X, e.Y, this);
            firework.SetRadius(random.Next(20, 35));
            firework.SetDirection(0, -Math.Abs(startPosition-endPosition)/10);
            firework.SetColor(Color.Blue);
            firework.StartMove();
        }
    }
}
