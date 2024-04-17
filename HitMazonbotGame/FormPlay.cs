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
        }

        bool MouseClickForm = false;
        Point startPoint = Point.Empty;

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
            if (MouseClickForm)
            {
                Point mousePoint = PointToScreen(e.Location);
                this.Location = new Point(mousePoint.X - startPoint.X, mousePoint.Y - startPoint.Y);
            }
        }

    }
}
