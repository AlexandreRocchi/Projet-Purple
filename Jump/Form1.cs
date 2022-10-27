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
        int jumpSpeed;
        int force;
        int playerSpeed = 10;

    

        public Form1()
        {
            InitializeComponent();
        }

        private void Main_Game(object sender, EventArgs e)
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
            else
            {
                jumpSpeed = 12;
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
                Console.WriteLine("Gauche");
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
                Console.WriteLine("Gauche desac");
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

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            player.Left = 24;
            player.Top = 687;

            gametimer.Start();


        }
    }
}
