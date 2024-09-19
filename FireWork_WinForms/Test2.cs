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
        public Test2_Form()
        {
            InitializeComponent();
        }

        private void Fire_Button_Click(object sender, EventArgs e)
        {
            var fireWork = new GravityBall(Width/2, Height, this);
            fireWork.SetDirection(0, -23f);
            fireWork.SetColor(Color.Pink);
            fireWork.StartMove();
            fireWork.actionTimer.Tick += ActionTimer_Tick;
            fireWork.actionTimer.Interval = random.Next(500, 680);
            fireWork.actionTimer.Start();
            balls.Add(fireWork);
        }

        private void ActionTimer_Tick(object? sender, EventArgs e)
        {
            GravityBall ball = balls.First();
            int firstIndex = balls.IndexOf(ball);
            ball.StopMove();
            ball.Clear();
            
            for (int i = 0; i < random.Next(8,15); i++)
            {
                var fireBall = new FireWorkBall(ball.centerX, ball.centerY, this);
                fireBall.SetColor(fireBall.RandomCollor());
                fireBall.StartMove();
            }
            balls.RemoveAt(firstIndex);
            ball.actionTimer.Stop();
            
        }
    }
}
