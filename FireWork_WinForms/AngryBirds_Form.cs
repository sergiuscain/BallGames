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
        public AngryBirds_Form()
        {
            InitializeComponent();
        }

        private void AngryBirds_Form_Load(object sender, EventArgs e)
        {
        }

        private void AngryBirds_Form_Shown(object sender, EventArgs e)
        {
            BirdBall bird = new BirdBall(0 + 50, Height - 80, this);
            bird.Show();
            PigBall pig = new PigBall(Width - 100, Height - 80, this);
            pig.Show();


        }
    }
}
