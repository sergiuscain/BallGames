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

namespace FireWorkAndAngryBirds_WinForms
{
    public partial class AngryBirds_Form : Form
    {
        BirdBall bird;
        PigBall pig;
        private float kX = 25;
        private float kY = 13;
        private float maxX = 15;
        private float maxY = -19;
        public AngryBirds_Form()
        {
            InitializeComponent();
        }

        private void AngryBirds_Form_Load(object sender, EventArgs e)
        {
        }

        private void AngryBirds_Form_Shown(object sender, EventArgs e)
        {
            bird = new BirdBall(0 + 50, Height - 80, this);
            bird.Show();
            pig = new PigBall(Width - 100, Height - 80, this);
            pig.Show();


        }

        private void AngryBirds_Form_MouseDown(object sender, MouseEventArgs e)
        {
            float x = (e.X - bird.centerX)/kX;
            float y = (e.Y - bird.centerY) / kY;
            if (x > maxX)
                x = maxX;
            if (y < maxY)
                y = maxY;
            bird.SetDirection(x,y);
            bird.StartMove();
        }
    }
}
