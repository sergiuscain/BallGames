namespace BallGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            var rectangle = new Rectangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text));
            var brush = Brushes.Aqua; 
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
