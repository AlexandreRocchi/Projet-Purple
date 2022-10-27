using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, IsGameOver;
        bool enemy_direction;
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 10;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int ennemyOneSpeed = 5;
        int enemyTwoSpeed = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                        {
                            Console.WriteLine("okokokooko");
                            force = 8;
                            player.Top = x.Top - player.Height;
                            jumpSpeed = 0;
                        }

                        x.BringToFront();
                    }
                }
            }
         }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && !jumping)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
    
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && IsGameOver == true)
            {
                ResetGame();
            }
        }

        private void ResetGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            IsGameOver = false;
            score = 0;

            //txtscore.Text = "Score : " + score;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            player.Left = 24;
            player.Top = 687;

            //enemyOne.Left = 475; 
            //enemyTwo.Left = 794;

            //horizontal.Left = 230;
            //vertical.Top = 287;

            gametimer.Start();


        }
    }
}
