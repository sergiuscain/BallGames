using FireWorkAndAngryBirds_WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireWork_WinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void test1_Button_Click(object sender, EventArgs e)
        {
            Test1_Form test1_Form = new Test1_Form();
            test1_Form.ShowDialog();
        }

        private void Test2_Button_Click(object sender, EventArgs e)
        {
            Test2_Form test2_Form = new Test2_Form();
            test2_Form.ShowDialog();
        }

        private void AngryBirds_Button_Click(object sender, EventArgs e)
        {
            AngryBirds_Form angryBirds_Form = new AngryBirds_Form();
            angryBirds_Form.ShowDialog();
        }
    }
}
