using System;
using System.Drawing;
using System.Windows.Forms;

namespace HitMazonbotGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.MouseMove += new MouseEventHandler(this.MouseMoveApp);
            this.MouseMove += new MouseEventHandler(this.MouseMoveApp);
            this.buttonExit.MouseClick += new MouseEventHandler(this.ButtonExit_Click);
            this.buttonHide.MouseClick += new MouseEventHandler(this.ButtonHide_Click);
        }

        bool MouseClickForm = false;
        Point startPoint = Point.Empty;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseClickForm = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void MouseMoveApp(object sender, MouseEventArgs e)
        {
            if (MouseClickForm)
            {
                Point mousePoint = PointToScreen(e.Location);
                this.Location = new Point(mousePoint.X - startPoint.X, mousePoint.Y - startPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseClickForm = false;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseClickForm = false;
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseClickForm = true;
            startPoint = new Point(e.X, e.Y);
        }
        
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
