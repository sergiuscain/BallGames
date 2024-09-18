using Timer = System.Windows.Forms.Timer;

namespace BallGames.Common;

    public class Ball 
    {
        Random random = new Random();
        public float centerX { get; protected set; }
        public float centerY { get; protected set; }
        public float vX { get; protected set; } = 0;
        public float vY { get; protected set; } = 0;
        public float radius { get; protected set; } = 16;
        protected Form form;
        protected Graphics graphics;
        protected Timer timer;
        public Color color { get; protected set; }
        protected Brush brush;
        public Random r = new Random();

        public Ball(float x, float y, Form form)
        {
            centerX = x-radius/2;
            centerY = y-radius/2;
            this.form = form;
            timer = new Timer();
            timer.Interval = 5;
            timer.Tick += Timer_Tick;
            brush = Brushes.Black;
        }


    private void Timer_Tick(object? sender, EventArgs e)
        {
            Step();
        }

        protected virtual void NextPosition()
        {
            centerX += vX;
            centerY += vY;
        }
        public void Clear()
        {
            var clearGraphics = form.CreateGraphics();
            var clearBrush = new SolidBrush(form.BackColor);
            clearGraphics.FillRectangle(clearBrush, centerX, centerY, radius, radius);
        }
        public void Show()
        {
            graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX, centerY, radius, radius);
            graphics.FillEllipse(brush, rectangle);
        }

        public  void Step()
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
            centerX = x;
            centerY = y;
        }

        public void SetSpeed(int speed)
        {
            timer.Interval = speed;
        }
        public void SetDirection(float vX, float vY)
        {
            this.vX = vX;
            this.vY = vY;
        }

        public bool IsCollision(int x, int y)
        {
            return (x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= radius*radius;
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
        this.color = color;
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

    public Color GetColor()
    {
        return this.color;
    }
}


// Ball class represents a ball in the game. It has properties for position, speed, and direction.