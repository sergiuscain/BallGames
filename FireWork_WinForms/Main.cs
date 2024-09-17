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
    }
}
