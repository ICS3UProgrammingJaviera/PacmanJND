using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PacmanJND
{
    public partial class PacmanLevel2 : Form
    {
        private SoundPlayer _soundPlayer;

        //declare global variables
        bool goup;
        bool godown;
        bool goleft;
        bool goright;

        int speed = 5;

        int ghost1 = 8;
        int ghost2 = 8;
        int ghost4 = 8;
        //horizontal and verticle movement axis
        int ghost3x = 8;
        int ghost3y = 8;

        int score = 0;

        public PacmanLevel2()
        {
            InitializeComponent();
            timer2.Start();
            lblGameOver.Visible = false;
            btnNextLevel.Visible = false;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //track key pressed and change pacman's image to match direction user pressed
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
                pacman.Image = Properties.Resources.Right;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
                pacman.Image = Properties.Resources.Left;
            }
            if (e.KeyCode == Keys.W)
            {
                goup = true;
                pacman.Image = Properties.Resources.Up;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
                pacman.Image = Properties.Resources.down;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            //when key is released make booleans false so that the image stops going in any direction, so that the image only moves when a key is being pressed.
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.W)

            {
                goup = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //change scoretext to "Score" and display number of score.
            lblScore.Text = "Score " + score;

            if (goleft)
            {
                pacman.Left -= speed;
                //move player left
            }
            if (goright)
            {
                pacman.Left += speed;
                //move player right
            }
            if (goup)
            {
                pacman.Top -= speed;
                //move player up
            }
            if (godown)
            {
                pacman.Top += speed;
                //move player down
            }

            //assign += to each ghost's variable
            redGhost.Left += ghost1;
            yellowGhost.Left += ghost2;
            blueGhost.Left += ghost4;

            //if red ghost intersects with given pictureboxes reverse speed
            if (redGhost.Bounds.IntersectsWith(PictureBox5.Bounds))
            {
                ghost1 = -ghost1;

            }
            else if (redGhost.Bounds.IntersectsWith(PictureBox6.Bounds))
            {
                ghost1 = -ghost1;

            }
            //if yellow ghost intersects with given pictureboxes reverse speed
            if (yellowGhost.Bounds.IntersectsWith(PictureBox2.Bounds))
            {
                ghost2 = -ghost2;

            }
            if (yellowGhost.Bounds.IntersectsWith(PictureBox9.Bounds))
            {
                ghost2 = -ghost2;

            }
            //if blue ghost intersects with given pictureboxes reverse speed
            if (blueGhost.Bounds.IntersectsWith(PictureBox4.Bounds))
            {
                ghost4 = -ghost4;

            }
            if (blueGhost.Bounds.IntersectsWith(PictureBox5.Bounds))
            {
                ghost4 = -ghost4;

            }
            if (blueGhost.Bounds.IntersectsWith(PictureBox36.Bounds))
            {
                ghost4 = -ghost4;

            }

            //loop t check player's relationship with walls, ghosts and game points
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall" || x.Tag == "ghost")
                    //if pacman hits a wall or ghost, display "Game Over" and stop timer
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds) || score == 30)
                    {
                        pacman.Left = 0;
                        pacman.Top = 25;
                        lblGameOver.Text = "Game Over";
                        btnNextLevel.Visible = true;
                        _soundPlayer = new SoundPlayer("Sad Violin - MLG Sound Effects.wav");
                        _soundPlayer.Play();
                        score = 0;
                        timer2.Stop();
                    }
                //check if player hit coin picturebox to add point
                if (x is PictureBox && x.Tag == "coin")
                {
                    //if player hit coin remove coin from game scene and add point to score
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        this.Controls.Remove(x);
                        score++;
                        _soundPlayer = new SoundPlayer("GetCoinEffect.wav");
                        _soundPlayer.Play();

                    }
                    if (score == 30)
                    {
                        lblGameOver.Text = "You Win!";
                    }
                }

            }

            pinkGhost.Left += ghost3x;
            pinkGhost.Top += ghost3y;

                //if ghost 3 runs into walls and borders with vertical and horizontal movement reverse speed
                if (pinkGhost.Left < 1 ||
                pinkGhost.Left + pinkGhost.Width > ClientSize.Width - 2 ||
                pinkGhost.Bounds.IntersectsWith(PictureBox36.Bounds) ||
                pinkGhost.Bounds.IntersectsWith(PictureBox37.Bounds) ||
                pinkGhost.Bounds.IntersectsWith(PictureBox17.Bounds) ||
                pinkGhost.Bounds.IntersectsWith(PictureBox38.Bounds) ||
                pinkGhost.Bounds.IntersectsWith(PictureBox16.Bounds))
            {
                ghost3x = -ghost3x;
            }
            if (pinkGhost.Top < 1 || pinkGhost.Top + pinkGhost.Height > ClientSize.Height - 2)
            {
                ghost3y = -ghost3y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PacmanLevel2_Load(object sender, EventArgs e)
        {

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            //refresh the form
            Controls.Clear();
            InitializeComponent();
            Refresh();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            PacmanLevel3 PacmanLevel3 = new PacmanLevel3();
            PacmanLevel3.Show();
            this.Visible = false;
        }
    }
}
