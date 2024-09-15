using Timer = System.Windows.Forms.Timer;

namespace BallGames.Common;

    public class Ball 
    {
        private int X { get; set; } = 0;
        private int Y { get; set; } = 0;
        private int vX { get; set; } = 5;
        private int vY { get; set; } = 5;
        private int radius { get; set; } = 40;
        private Form form;
        private Graphics graphics;
        private Timer timer;
        private Brush brush;

        public Ball(int x, int y, Form form)
        {
            X = x;
            Y = y;
            this.form = form;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            brush = Brushes.Black;
        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            Step();
        }

        private void NextPosition()
        {
            X += vX;
            Y += vY;
        }
        public void Clear()
        {
            var clearGraphics = form.CreateGraphics();
            var clearBrush = new SolidBrush(form.BackColor);
            clearGraphics.FillRectangle(clearBrush, X, Y, radius, radius);
        }
        public void Show()
        {
            graphics = form.CreateGraphics();
            var rectangle = new Rectangle(X, Y, radius, radius);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Step()
        {
            Clear();
            NextPosition();
            Show();
        }
        public void StartMove()
        {
            timer.Start();
        }
        public void StopMove()
        {
            timer.Stop();
        }

        public void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void SetSpeed(int speed)
        {
            timer.Interval = speed;
        }
        public void SetDirection(int vX, int vY)
        {
            this.vX = vX;
            this.vY = vY;
        }

        public bool IsCollision(int x, int y)
        {
            return (x - X) * (x - X) + (y - Y) * (y - Y) <= radius*radius;
        }
        public void ReverseDirection()
        {
            vX = -vX;
            vY = -vY;
        }
        public bool IsMoving()
        {
            return timer.Enabled;
        }
        public void SetColor(Color color)
    {
        brush = new SolidBrush(color);
    }
}


// Ball class represents a ball in the game. It has properties for position, speed, and direction.