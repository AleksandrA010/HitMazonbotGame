using System;
using System.Drawing;
using System.Windows.Forms;

namespace HitMazonbotGame
{
    public partial class FormPlay : Form
    {
        public FormPlay()
        {
            InitializeComponent();

            this.Title.MouseEnter += new EventHandler(this.Header_MouseEnter);
            this.Title.MouseLeave += new EventHandler(this.Header_MouseLeave);

            this.Title.MouseDown += new MouseEventHandler(this.Header_MouseDown);
            this.Title.MouseUp += new MouseEventHandler(this.Header_MouseUp);
            this.Title.MouseMove += new MouseEventHandler(this.Header_MouseMove);

            this.buttonExit2.MouseEnter += new EventHandler(this.Header_MouseEnter);
            this.buttonExit2.MouseLeave += new EventHandler(this.Header_MouseLeave);

            this.buttonExit2.MouseDown += new MouseEventHandler(this.Header_MouseDown);
            this.buttonExit2.MouseUp += new MouseEventHandler(this.Header_MouseUp);
            this.buttonExit2.MouseMove += new MouseEventHandler(this.Header_MouseMove);

            this.buttonHide.MouseEnter += new EventHandler(this.Header_MouseEnter);
            this.buttonHide.MouseLeave += new EventHandler(this.Header_MouseLeave);

            this.buttonHide.MouseDown += new MouseEventHandler(this.Header_MouseDown);
            this.buttonHide.MouseUp += new MouseEventHandler(this.Header_MouseUp);
            this.buttonHide.MouseMove += new MouseEventHandler(this.Header_MouseMove);

        }

        bool MouseClickForm = false;
        bool MouseEnterHeader = false;

        Point startPoint = Point.Empty;

        bool flag1 = true;
        bool flag2 = true;

        int Score = 0;

        bool hammerIsHit = false;
        int countTick = 0;

        readonly Bitmap hammer = Images.Hammer;
        readonly Bitmap hammerHit = Images.HammerHit;
        readonly Bitmap mazonBot = Images.MazonBot;

        Rectangle handlerRect = Rectangle.Empty;
        Rectangle mazonObjectRect = Rectangle.Empty;

        bool mazonObjectFlag = true;
        Point currentMazonObjectRect = Point.Empty;

        Point localPosition = Point.Empty;

        private void ButtonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            MouseClickForm = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            MouseClickForm = false;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEnterHeader = true;

            if (MouseClickForm)
            {
                Point mousePoint = PointToScreen(e.Location);
                this.Location = new Point(mousePoint.X - startPoint.X, mousePoint.Y - startPoint.Y);
            }
        }

        private void FormPlay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Random random = new Random();

            localPosition = this.PointToClient(Cursor.Position);

            if (mazonObjectFlag)
            {
                currentMazonObjectRect = new Point(random.Next(50, this.Width - 100),
                    random.Next(100, this.Height - 100));

                mazonObjectRect = new Rectangle(currentMazonObjectRect.X, currentMazonObjectRect.Y, 50, 50);

                g.DrawImage(mazonBot, mazonObjectRect);

                mazonObjectFlag = false;
            }
            else
            {
                mazonObjectRect = new Rectangle(currentMazonObjectRect.X, currentMazonObjectRect.Y, 50, 50);
                g.DrawImage(mazonBot, mazonObjectRect);
            }

            if (localPosition.Y > Header.Height)
            {
                handlerRect = new Rectangle(localPosition.X - 15, localPosition.Y - 15, 50, 50);
            }

            if (hammerIsHit)
                g.DrawImage(hammerHit, handlerRect);
            else
                g.DrawImage(hammer, handlerRect);
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            Refresh();

            if (MouseEnterHeader && flag1)
            {
                Cursor.Show();
                flag1 = false;
                flag2 = true;
            }
            else if (!MouseEnterHeader && flag2)
            {
                Cursor.Hide();
                flag2 = false;
                flag1 = true;
            }

            if (localPosition.X > currentMazonObjectRect.X && localPosition.X < (currentMazonObjectRect.X + 50) 
                && (localPosition.Y + 20) > currentMazonObjectRect.Y && (localPosition.Y + 20) < (currentMazonObjectRect.Y + 50)
                && hammerIsHit)
            {
                mazonObjectFlag = true;

                ScoreLabel.Text = "Счёт: " + (++Score).ToString();
            }
        }

        private void Header_MouseLeave(object sender, EventArgs e)
        {
            MouseEnterHeader = false;
        }

        private void Header_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterHeader = true;
        }

        private void FormPlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseEnterHeader == false && countTick == 0)
            {
                timerHit.Start();
                hammerIsHit = true;
            }
        }

        private void timerHit_Tick(object sender, EventArgs e)
        {
            countTick++;

            if (countTick == 2 || countTick == 3)
            {
                hammerIsHit = false;
            }
            else if (countTick >= 4)
            {
                timerHit.Stop();
                countTick = 0;
            }
        }
    }
}
