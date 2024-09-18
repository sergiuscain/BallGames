using BallGames.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FireWork_WinForms
{
    public partial class Test2_Form : Form
    {
        Random random = new Random();
        public List<GravityBall> balls = new List<GravityBall>();
        Timer startFireTimer = new Timer();
        public Test2_Form()
        {
            InitializeComponent();
        }

        private void Fire_Button_Click(object sender, EventArgs e)
        {
            var fireWork = new GravityBall(Width/2, Height, this);
            fireWork.SetDirection(0, -20f);
            fireWork.SetColor(Color.Pink);
            fireWork.StartMove();
            startFireTimer.Interval = 500;
            startFireTimer.Start();
            startFireTimer.Tick += StartFireTimer_Tick;
            balls.Add(fireWork);
        }

        private void StartFireTimer_Tick(object? sender, EventArgs e)
        {
            GravityBall ball = balls[balls.Count - 1];
            ball.StopMove();
            ball.Clear();
            startFireTimer.Stop();
            for (int i = 0; i < random.Next(8,15); i++)
            {
                var fireBall = new FireWorkBall(ball.centerX, ball.centerY, this);
                fireBall.SetColor(fireBall.RandomCollor());
                fireBall.StartMove();
            }
        }
    }
}
