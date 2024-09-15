using Timer = System.Windows.Forms.Timer;

namespace BallGames.Common;

    public class Ball 
    {
        private int X { get; set; } = 0;
        private int Y { get; set; } = 0;
        private int vX { get; set; } = 5;
        private int vY { get; set; } = 5;
        private int radius { get; set; } = 20;
        private Form form;
        private Graphics graphics;
        private Timer timer;
        private Brush brush;
        Random r = new Random();

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

    public Color RandomCollor()
    {
        int colorNumber = r.Next(0, 20);
        switch (colorNumber)
        {
            case 0:
                return Color.Red;
            case 1:
                return Color.Green;
            case 2:
                return Color.Blue;
                case 3:
                return Color.Magenta;
                case 4:
                return Color.Yellow;
                case 5:
                return Color.Orange;
                case 6:
                return Color.Orchid;
                case 7:
                return Color.Lime;
                case 8:
                return Color.LimeGreen;
                case 9:
                return Color.LightGreen;
                case 10:
                return Color.Pink;
                case 11:
                return Color.Purple;
                case 12:
                return Color.Orchid;
                case 13:
                return Color.SteelBlue;
                case 14:
                return Color.Yellow;
                case 15:
                return Color.Orchid;
                case 16:
                return Color.LimeGreen;
                case 17:
                return Color.LightGreen;
                case 18:
                return Color.Pink;
                case 19:
                return Color.Purple;
                case 20:
                return Color.Orchid;
        }
        return Color.Black;
    }

    public void SetRadius(int radius)
    {
        this.radius = radius;
    }
}


// Ball class represents a ball in the game. It has properties for position, speed, and direction.