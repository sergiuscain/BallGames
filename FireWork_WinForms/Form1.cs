using BallGames.Common;

namespace FireWork_WinForms
{
    public partial class Form1 : Form
    {
        private float startPosition = 0;
        private float endPosition = 0;
        private float startMinusEndPosition = 0;
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            var firework = new GravityBall(e.X, e.Y,this);
            firework.SetRadius(random.Next(20, 35));
            firework.SetDirection(0, random.Next(-20,-10));
            firework.SetColor(Color.Blue);
            firework.StartMove();
        }
    }
}
