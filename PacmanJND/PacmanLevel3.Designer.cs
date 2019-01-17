namespace PacmanJND
{
    partial class PacmanLevel3
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
            this.pacman = new System.Windows.Forms.PictureBox();
            this.blueGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            this.SuspendLayout();
            // 
            // pacman
            // 
            this.pacman.BackColor = System.Drawing.Color.Transparent;
            this.pacman.Image = global::PacmanJND.Properties.Resources.Right;
            this.pacman.Location = new System.Drawing.Point(100, 176);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(40, 40);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 8;
            this.pacman.TabStop = false;
            this.pacman.Tag = "pacman";
            // 
            // blueGhost
            // 
            this.blueGhost.BackColor = System.Drawing.Color.Transparent;
            this.blueGhost.Image = global::PacmanJND.Properties.Resources.blue_ghost_gif;
            this.blueGhost.Location = new System.Drawing.Point(464, 189);
            this.blueGhost.Name = "blueGhost";
            this.blueGhost.Size = new System.Drawing.Size(36, 38);
            this.blueGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueGhost.TabIndex = 46;
            this.blueGhost.TabStop = false;
            this.blueGhost.Tag = "ghost";
            // 
            // pinkGhost
            // 
            this.pinkGhost.BackColor = System.Drawing.Color.Transparent;
            this.pinkGhost.Image = global::PacmanJND.Properties.Resources.pink_guy;
            this.pinkGhost.Location = new System.Drawing.Point(295, 239);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 38);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 47;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblScore.Location = new System.Drawing.Point(54, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(57, 20);
            this.lblScore.TabIndex = 48;
            this.lblScore.Text = "label1";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblGameOver.Location = new System.Drawing.Point(326, 138);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(97, 36);
            this.lblGameOver.TabIndex = 49;
            this.lblGameOver.Text = "label2";
            // 
            // redGhost
            // 
            this.redGhost.BackColor = System.Drawing.Color.Transparent;
            this.redGhost.Image = global::PacmanJND.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(395, 242);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 38);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 50;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // yellowGhost
            // 
            this.yellowGhost.Image = global::PacmanJND.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(332, 358);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 38);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 51;
            this.yellowGhost.TabStop = false;
            this.yellowGhost.Tag = "ghost";
            // 
            // PacmanLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 523);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.blueGhost);
            this.Controls.Add(this.pacman);
            this.Name = "PacmanLevel3";
            this.Text = "PacmanLevel3";
            this.Load += new System.EventHandler(this.PacmanLevel3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.PictureBox blueGhost;
        private System.Windows.Forms.PictureBox pinkGhost;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox yellowGhost;
    }
}