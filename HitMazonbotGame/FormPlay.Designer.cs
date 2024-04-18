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
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerHit = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
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
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 50;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerHit
            // 
            this.timerHit.Interval = 200;
            this.timerHit.Tick += new System.EventHandler(this.timerHit_Tick);
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 424);
            this.Controls.Add(this.Header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPlay_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPlay_MouseDown);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerHit;
    }
}