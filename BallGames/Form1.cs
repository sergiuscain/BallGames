using BallGames.Common;

namespace BallGames
{
    public partial class Form1 : Form
    {
        Ball ball;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ball = new Ball(0, 0, this);
            ball.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ball.Clear();
        }
    }
}
 