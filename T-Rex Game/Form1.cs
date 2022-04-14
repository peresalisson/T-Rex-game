using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Game
{
    public partial class Form1 : Form
    {

        bool jump = false;
        int jumpSpeed;
        int limit = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position;
        bool isGameOver = false;
        readonly Random random = new(); 

        public Form1()
        {
            InitializeComponent();

            //Calls the Reset() everytime the game loads again
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            //linking the jumpspeed integer with the player picture boxes to location
            trex.Top += jumpSpeed;

            scoreText.Text = "Score: " + score;

            if (jump && limit < 0)
            {
                jump = false;
            }

            // change jump speed to -12 
            // reduce limit by 1
            if (jump)
            {
                jumpSpeed = -12;
                limit -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed; // move the obstacles towards the left

                    if (x.Left < -100)
                    {
                        // if the obstacles have gone off the screen, then we respawn it off the far right and add +1 to score
                        x.Left = random.Next(300, 600) + (x.Width*15);
                        score++;
                    }

                    // if the t rex collides with the obstacles
                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        scoreText.Text = "Press R to restart";
                        isGameOver = true;
                    }
                }
            }

            if (trex.Top >= 367 && !jump)
            {
                limit = 12; 
                trex.Top = floor.Top - trex.Height; 
                jumpSpeed = 0; 
            }

            // if score is equals or greater than 10, the obstacles will move faster
            if (score >= 10)
            {
                obstacleSpeed = 15;
            }
        }
    

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //This sets the space bar as the jump button
            if (e.KeyCode == Keys.Space && jump == false)
            {
                jump = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jump == true)
            {
                jump = false;
            }

            if (e.KeyCode == Keys.R && isGameOver)
            {
                Reset();
            }
        }

        private void Reset()
        {
            jump = false;
            jumpSpeed = 0;
            limit = 12;
            score = 0;
            obstacleSpeed = 10;

            scoreText.Text = "score: " + score;

            //T-rex image and location(y)
            trex.Image = Properties.Resources.running;
            trex.Top = 368;

            isGameOver = false;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //generates the position of the obstacles
                    position = this.ClientSize.Width + random.Next(500, 800);

                    x.Left = position; 
                }
            }

            gameTimer.Start();
        }
    }
}
