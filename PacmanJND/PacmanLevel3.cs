using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanJND
{
    public partial class PacmanLevel3 : Form
    {
        //declare global variables
        bool goup;
        bool godown;
        bool goleft;
        bool goright;

        int speed = 5;

        int ghost1 = 8;
        int ghost2 = 8;
        //horizontal and verticle movement axis
        int ghost3x = 8;
        int ghost3y = 8;
        int ghost4x = 8;
        int ghosty = 8;

        int score = 0;

        public PacmanLevel3()
        {
            InitializeComponent();
            timer3.Start();
        }

        private void PacmanLevel3_Load(object sender, EventArgs e)
        {

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
    }
}
