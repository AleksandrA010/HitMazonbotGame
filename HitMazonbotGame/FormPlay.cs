using System;
using System.Drawing;
using System.Windows.Forms;

namespace HitMazonbotGame
{
    public partial class FormPlay : Form
    {
        public static FormPlay formPlay;
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

            this.stripOfLife.Width = 200;
            this.stripOfLifeMax.Width = 200;

            this.stripOfLifeMax.Location = new Point(this.stripOfLifeMax.Location.X + 20, this.stripOfLifeMax.Location.Y);
            this.Life.Location = new Point(this.Life.Location.X + 20, this.Life.Location.Y - 1);

            this.Life.Text = stripOfLife.Width.ToString();

            difficultScore = 0;
            timerDifficulty.Interval = 20000;

            timerGamePlay.Start();
            TimerGame.Start();
            timerDifficulty.Start();

        }

        int HitOnTick = 5;

        int difficultScore = 0;

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

        bool isMenu = false;

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

            if (isMenu)
            {
                handlerRect = Rectangle.Empty;
                mazonObjectRect = Rectangle.Empty;

                g.DrawImage(hammerHit, handlerRect);
                g.DrawImage(mazonBot, mazonObjectRect);

                return;
            }

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

            if (localPosition.Y > Header.Height && 
                !((localPosition.X) >= Menu.Location.X &&
                (localPosition.X) <= (Menu.Location.X + 40) &&
                (localPosition.Y + 8) >= Menu.Location.Y &&
                (localPosition.Y + 8) <= (Menu.Location.Y + 40)))
            {
                handlerRect = new Rectangle(localPosition.X - 15, localPosition.Y - 15, 50, 50);
            }
            else if ((localPosition.X) >= Menu.Location.X &&
                (localPosition.X) <= (Menu.Location.X + 40) &&
                (localPosition.Y + 8) >= Menu.Location.Y &&
                (localPosition.Y + 8) <= (Menu.Location.Y + 40))
            {
                handlerRect = Rectangle.Empty;
            }

            if (hammerIsHit)
                g.DrawImage(hammerHit, handlerRect);
            else
                g.DrawImage(hammer, handlerRect);
        }

        private void TimerGame_Tick(object sender, EventArgs e)
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

            if (int.Parse(Life.Text) == 0)
            {
                TimerGame.Stop();
                TimerHit.Stop();
                timerGamePlay.Stop();
                timerDifficulty.Stop();

                hammerIsHit = false;

                isMenu = true;
                Refresh();

                this.Menu.Hide();
                this.stripOfLife.Hide();
                this.stripOfLifeMax.Hide();
                this.ScoreLabel.Hide();
                this.Life.Hide();
                this.DifficultLabel.Hide();

                this.panelGameOver.Show();
                this.panelGameOver.Visible = true;
                this.panelGameOver.Enabled = true;

                Cursor.Show();

                this.ScoreGameOver.Text = "Ваш счёт: " + Score.ToString();

                this.BackgroundImage = Images.BlurredBackground;
                    
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
                TimerHit.Start();
                hammerIsHit = true;
            }

            if (localPosition.X > currentMazonObjectRect.X && localPosition.X < (currentMazonObjectRect.X + 50)
                && (localPosition.Y + 20) > currentMazonObjectRect.Y && (localPosition.Y + 20) < (currentMazonObjectRect.Y + 50)
                && hammerIsHit)
            {
                mazonObjectFlag = true;

                ScoreLabel.Text = "Счёт: " + (++Score).ToString();

                if ((stripOfLife.Width + 5) > 200)
                    stripOfLife.Width = 200;
                else
                    stripOfLife.Width += 5;

                Life.Text = stripOfLife.Width.ToString();
            }
            else if (MouseEnterHeader == false && countTick == 0)
            {
                stripOfLife.Width -= 10;
                Life.Text = stripOfLife.Width.ToString();
            }
        }

        private void TimerHit_Tick(object sender, EventArgs e)
        {
            countTick++;

            if (countTick == 2 || countTick == 3)
            {
                hammerIsHit = false;
            }
            else if (countTick >= 4)
            {
                TimerHit.Stop();
                countTick = 0;
            }
        }

        private void TimerGamePlay_Tick(object sender, EventArgs e)
        {
            stripOfLife.Width -= HitOnTick;
            Life.Text = stripOfLife.Width.ToString();
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterHeader = true;
            Menu.Image = Images.MenuEnter;
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            MouseEnterHeader = false;
            Menu.Image = Images.Menu;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            TimerGame.Stop();
            TimerHit.Stop();
            timerGamePlay.Stop();
            timerDifficulty.Stop();

            isMenu = true;
            Refresh();

            this.Menu.Hide();
            this.stripOfLife.Hide();
            this.stripOfLifeMax.Hide();
            this.ScoreLabel.Hide();
            this.Life.Hide();
            this.DifficultLabel.Hide();

            this.Pause.Show();
            this.Pause.Visible = true;
            this.Pause.Enabled = true;

            Cursor.Show();
            this.BackgroundImage = Images.BlurredBackground;

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            this.Menu.Show();
            this.stripOfLife.Show();
            this.stripOfLifeMax.Show();
            this.ScoreLabel.Show();
            this.Life.Show();
            this.DifficultLabel.Show();

            this.Pause.Hide();
            this.Pause.Visible = false;
            this.Pause.Enabled = false;

            isMenu = false;

            timerGamePlay.Start();
            TimerGame.Start();
            timerDifficulty.Start();

            this.BackgroundImage = null;

            Cursor.Hide();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            TimerGame.Stop();
            TimerHit.Stop();
            timerGamePlay.Stop();
            timerDifficulty.Stop();

            isMenu = false;
            this.Hide();
            FormMain.formMain.Show();
            FormMain.formMain.Location = this.Location;
            this.Close();
            Cursor.Hide();
        }

        private void PlayGameOver_Click(object sender, EventArgs e)
        {
            this.Menu.Show();
            this.stripOfLife.Show();
            this.stripOfLifeMax.Show();
            this.ScoreLabel.Show();
            this.Life.Show();
            this.DifficultLabel.Show();

            this.panelGameOver.Hide();
            this.panelGameOver.Visible = false;
            this.panelGameOver.Enabled = false;

            Cursor.Hide();
            isMenu = false;

            this.BackgroundImage = null;

            this.stripOfLifeMax.Width = 200;
            this.stripOfLife.Width = 200;

            Score = 0;
            ScoreLabel.Text = "Счёт: " + Score.ToString();

            this.Life.Text = stripOfLife.Width.ToString();

            difficultScore = 0;
            this.DifficultLabel.Text = "Сложность: " + difficultScore.ToString();
            timerDifficulty.Interval = 20000;

            timerGamePlay.Start();
            TimerGame.Start();
            timerDifficulty.Start();

            hammerIsHit = false;

            this.TopMost = true;
        }

        private void MenuGameOver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain.formMain.Show();
            FormMain.formMain.Location = this.Location;
            isMenu = false;
            this.Close();
        }

        private void TimerDifficulty_Tick(object sender, EventArgs e)
        {
            if (difficultScore < 10)
            {
                if (difficultScore % 2 == 0)
                    timerGamePlay.Interval -= 100;
                else
                    HitOnTick++;

                difficultScore++;
                timerDifficulty.Interval += 10000;
                DifficultLabel.Text = "Сложность: " + difficultScore.ToString();
            }
        }
    }
}
