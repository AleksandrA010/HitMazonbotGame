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

            this.buttonExit2.MouseEnter += new EventHandler(this.Header_MouseEnter);
            this.buttonExit2.MouseLeave += new EventHandler(this.Header_MouseLeave);

            this.buttonHide.MouseEnter += new EventHandler(this.Header_MouseEnter);
            this.buttonHide.MouseLeave += new EventHandler(this.Header_MouseLeave);

            GameInit();
        }

        bool MouseClickForm = false;
        bool MouseEnterHeader = false;
        Point startPoint = Point.Empty;
        bool flag1 = true;
        bool flag2 = true;
        bool hammerIsHit = false;

        readonly Bitmap hammer = Images.Hammer;
        readonly Bitmap hammerHit = Images.HammerHit;

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

        private void GameInit()
        {
            Random random = new Random();
            bool gameFlag = false;
            Point pointObject = new Point();

        }

        private void FormPlay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            var localPosition = this.PointToClient(Cursor.Position);
            Rectangle handlerRect = Rectangle.Empty;

            if (localPosition.Y > Header.Height)
            {
                handlerRect = new Rectangle(localPosition.X - 15, localPosition.Y - 15, 50, 50);
            }

            if (!hammerIsHit)
                g.DrawImage(hammer, handlerRect);
            else
                g.DrawImage(hammerHit, handlerRect);
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
            if (!MouseEnterHeader && timerHit.Interval > 100)
            {
                hammerIsHit = true;
            }

            timerHit.Start();
        }

        private void timerHit_Tick(object sender, EventArgs e)
        {
            timerHit.Stop();
            hammerIsHit = false;
        }
    }
}
