using BallGames.Common;
using Timer = System.Windows.Forms.Timer;

namespace BilliardBalls_WinForms
{
    public partial class Form1 : Form
    {
        public List<Ball> balls = new List<Ball>();
        Random random = new Random();
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 5;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            int countLeftRed = 0;
            int countLeftBlue = 0;

            int countRightRed = 0;
            int countRightBlue = 0;
            foreach (Ball b in balls)
            {
                if (b.centerX < Width / 2)
                {
                    if (b.GetColor() == Color.Blue)
                    {
                        countLeftBlue++;
                    }
                    else
                        countLeftRed++;
                }
                else
                {
                    if (b.GetColor() == Color.Blue)
                    {
                        countRightBlue++;
                    }
                    else
                        countRightRed++;
                }
            }
            leftBlueLabel.Text = countLeftBlue.ToString();
            leftRedLabel.Text = countLeftRed.ToString();

            rightBlueLabel.Text = countRightBlue.ToString();
            rightRedLabel.Text = countRightRed.ToString();

            if (countLeftRed == countRightRed && countLeftBlue == countRightBlue)
            {
                foreach (Ball b in balls)
                {
                    b.StopMove();
                }
                timer.Stop();
                MessageBox.Show("Произошла диффузия или типа того");
                leftBlueLabel.Text = "0";
                leftRedLabel.Text = "0";

                rightBlueLabel.Text = "0";
                rightRedLabel.Text = "0";
                foreach (Ball b in balls)
                {
                    b.Clear();
                }
                balls.Clear();
                button1.Enabled = true;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                var ball = new BilliardBall(random.Next(0, Width / 2), random.Next(0, Height), this);
                ball.SetColor(Color.Red);
                ball.SetDirection(random.Next(-10, 10), random.Next(-10, 10));
                ball.SetSpeed(1);
                ball.StartMove();
                balls.Add(ball);
            }

            for (int i = 0; i < 50; i++)
            {
                var ball = new BilliardBall(random.Next(Width / 2, Width), random.Next(0, Height), this);
                ball.SetColor(Color.Blue);
                ball.SetDirection(random.Next(-10, 10), random.Next(-10, 10));
                ball.SetSpeed(1);
                ball.StartMove();
                balls.Add(ball);
            }
            timer.Start();
            button1.Enabled = false;
        }

    }
}
