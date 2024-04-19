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
            this.Header.SuspendLayout();
            this.stripOfLifeMax.SuspendLayout();
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
            this.ScoreLabel.Location = new System.Drawing.Point(12, 396);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(103, 17);
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
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(824, 424);
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
    }
}