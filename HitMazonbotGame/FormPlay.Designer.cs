namespace HitMazonbotGame
{
    partial class FormPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.TimerHit = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.stripOfLife = new System.Windows.Forms.Panel();
            this.stripOfLifeMax = new System.Windows.Forms.Panel();
            this.timerGamePlay = new System.Windows.Forms.Timer(this.components);
            this.Life = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.PauseTitle = new System.Windows.Forms.Label();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.MenuGameOver = new System.Windows.Forms.Button();
            this.PlayGameOver = new System.Windows.Forms.Button();
            this.ScoreGameOver = new System.Windows.Forms.Label();
            this.TextGameOver = new System.Windows.Forms.Label();
            this.timerDifficulty = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.DifficultLabel = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.stripOfLifeMax.SuspendLayout();
            this.Pause.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.buttonHide);
            this.Header.Controls.Add(this.buttonExit2);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(824, 40);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseEnter += new System.EventHandler(this.Header_MouseEnter);
            this.Header.MouseLeave += new System.EventHandler(this.Header_MouseLeave);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(226, 29);
            this.Title.TabIndex = 3;
            this.Title.Text = "Hit MazonBot Game";
            // 
            // buttonHide
            // 
            this.buttonHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHide.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonHide.Location = new System.Drawing.Point(744, 0);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(40, 40);
            this.buttonHide.TabIndex = 2;
            this.buttonHide.Text = "–";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonExit2
            // 
            this.buttonExit2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.buttonExit2.FlatAppearance.BorderSize = 0;
            this.buttonExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit2.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit2.Location = new System.Drawing.Point(784, 0);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(40, 40);
            this.buttonExit2.TabIndex = 1;
            this.buttonExit2.Text = "X";
            this.buttonExit2.UseVisualStyleBackColor = true;
            this.buttonExit2.Click += new System.EventHandler(this.ButtonExit2_Click);
            // 
            // TimerGame
            // 
            this.TimerGame.Enabled = true;
            this.TimerGame.Interval = 50;
            this.TimerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // TimerHit
            // 
            this.TimerHit.Tick += new System.EventHandler(this.TimerHit_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 370);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(160, 20);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Счёт: 0";
            // 
            // stripOfLife
            // 
            this.stripOfLife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.stripOfLife.Location = new System.Drawing.Point(0, 0);
            this.stripOfLife.Name = "stripOfLife";
            this.stripOfLife.Size = new System.Drawing.Size(300, 12);
            this.stripOfLife.TabIndex = 3;
            // 
            // stripOfLifeMax
            // 
            this.stripOfLifeMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stripOfLifeMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stripOfLifeMax.Controls.Add(this.stripOfLife);
            this.stripOfLifeMax.Location = new System.Drawing.Point(508, 400);
            this.stripOfLifeMax.Name = "stripOfLifeMax";
            this.stripOfLifeMax.Size = new System.Drawing.Size(300, 12);
            this.stripOfLifeMax.TabIndex = 2;
            // 
            // timerGamePlay
            // 
            this.timerGamePlay.Interval = 2000;
            this.timerGamePlay.Tick += new System.EventHandler(this.TimerGamePlay_Tick);
            // 
            // Life
            // 
            this.Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Life.Location = new System.Drawing.Point(450, 396);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(43, 17);
            this.Life.TabIndex = 3;
            this.Life.Text = "200";
            // 
            // Menu
            // 
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(772, 46);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(40, 40);
            this.Menu.TabIndex = 4;
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            this.Menu.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.Menu.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.Pause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pause.Controls.Add(this.MainMenu);
            this.Pause.Controls.Add(this.Continue);
            this.Pause.Controls.Add(this.PauseTitle);
            this.Pause.Enabled = false;
            this.Pause.Location = new System.Drawing.Point(282, 91);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(260, 257);
            this.Pause.TabIndex = 5;
            this.Pause.Visible = false;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenu.FlatAppearance.BorderSize = 0;
            this.MainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenu.Location = new System.Drawing.Point(56, 156);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(154, 44);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "Главное Меню";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Continue.FlatAppearance.BorderSize = 0;
            this.Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue.Location = new System.Drawing.Point(56, 93);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(154, 44);
            this.Continue.TabIndex = 1;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // PauseTitle
            // 
            this.PauseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseTitle.ForeColor = System.Drawing.Color.White;
            this.PauseTitle.Location = new System.Drawing.Point(60, 23);
            this.PauseTitle.Name = "PauseTitle";
            this.PauseTitle.Size = new System.Drawing.Size(141, 43);
            this.PauseTitle.TabIndex = 0;
            this.PauseTitle.Text = "Пауза";
            this.PauseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.panelGameOver.Controls.Add(this.MenuGameOver);
            this.panelGameOver.Controls.Add(this.PlayGameOver);
            this.panelGameOver.Controls.Add(this.ScoreGameOver);
            this.panelGameOver.Controls.Add(this.TextGameOver);
            this.panelGameOver.Enabled = false;
            this.panelGameOver.Location = new System.Drawing.Point(262, 90);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(300, 240);
            this.panelGameOver.TabIndex = 6;
            this.panelGameOver.Visible = false;
            // 
            // MenuGameOver
            // 
            this.MenuGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuGameOver.FlatAppearance.BorderSize = 0;
            this.MenuGameOver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.MenuGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuGameOver.Location = new System.Drawing.Point(160, 180);
            this.MenuGameOver.Name = "MenuGameOver";
            this.MenuGameOver.Size = new System.Drawing.Size(120, 40);
            this.MenuGameOver.TabIndex = 7;
            this.MenuGameOver.Text = "В меню";
            this.MenuGameOver.UseVisualStyleBackColor = false;
            this.MenuGameOver.Click += new System.EventHandler(this.MenuGameOver_Click);
            // 
            // PlayGameOver
            // 
            this.PlayGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PlayGameOver.FlatAppearance.BorderSize = 0;
            this.PlayGameOver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.PlayGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayGameOver.Location = new System.Drawing.Point(20, 180);
            this.PlayGameOver.Name = "PlayGameOver";
            this.PlayGameOver.Size = new System.Drawing.Size(120, 40);
            this.PlayGameOver.TabIndex = 6;
            this.PlayGameOver.Text = "Заново";
            this.PlayGameOver.UseVisualStyleBackColor = false;
            this.PlayGameOver.Click += new System.EventHandler(this.PlayGameOver_Click);
            // 
            // ScoreGameOver
            // 
            this.ScoreGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreGameOver.ForeColor = System.Drawing.Color.White;
            this.ScoreGameOver.Location = new System.Drawing.Point(75, 90);
            this.ScoreGameOver.Name = "ScoreGameOver";
            this.ScoreGameOver.Size = new System.Drawing.Size(150, 30);
            this.ScoreGameOver.TabIndex = 4;
            this.ScoreGameOver.Text = "Ваш счёт: ";
            this.ScoreGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextGameOver
            // 
            this.TextGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextGameOver.ForeColor = System.Drawing.Color.White;
            this.TextGameOver.Location = new System.Drawing.Point(65, 30);
            this.TextGameOver.Name = "TextGameOver";
            this.TextGameOver.Size = new System.Drawing.Size(170, 40);
            this.TextGameOver.TabIndex = 3;
            this.TextGameOver.Text = "Игра окончена";
            this.TextGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDifficulty
            // 
            this.timerDifficulty.Interval = 20000;
            this.timerDifficulty.Tick += new System.EventHandler(this.TimerDifficulty_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            // 
            // DifficultLabel
            // 
            this.DifficultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultLabel.Location = new System.Drawing.Point(12, 393);
            this.DifficultLabel.Name = "DifficultLabel";
            this.DifficultLabel.Size = new System.Drawing.Size(160, 20);
            this.DifficultLabel.TabIndex = 9;
            this.DifficultLabel.Text = "Сложность: 0";
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(824, 424);
            this.Controls.Add(this.DifficultLabel);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Life);
            this.Controls.Add(this.stripOfLifeMax);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPlay_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPlay_MouseDown);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.stripOfLifeMax.ResumeLayout(false);
            this.Pause.ResumeLayout(false);
            this.panelGameOver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.Timer TimerHit;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel stripOfLife;
        private System.Windows.Forms.Panel stripOfLifeMax;
        private System.Windows.Forms.Timer timerGamePlay;
        private System.Windows.Forms.Label Life;
        private new System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Panel Pause;
        private System.Windows.Forms.Label PauseTitle;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Label ScoreGameOver;
        private System.Windows.Forms.Label TextGameOver;
        private System.Windows.Forms.Button MenuGameOver;
        private System.Windows.Forms.Button PlayGameOver;
        private System.Windows.Forms.Timer timerDifficulty;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label DifficultLabel;
    }
}