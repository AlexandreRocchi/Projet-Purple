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
        bool platformstar_move = true;
        bool Hard = false;
        bool Menu = false;
        int jumpSpeed;
        int gravity;
        int playerSpeed;
        int enemy1Speed = 3;
        int platformSpeed = 2;
        int characterSkin;
        int score = 0;
        double time;

        public Form1()
        {
            InitializeComponent();
        }

        private void Main_Game(object sender, EventArgs e)
        {
            time = time + 0.03;
            label4.Text = "Temps : " + Math.Round(time,1).ToString() + " s";

            if (characterSkin == 0)
            {
                player.BackColor = Color.DarkBlue;
                playerSpeed = 15;
            }
            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping == true && gravity < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                gravity -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            enemy1.Left -= enemy1Speed;

            if (enemy1.Left < platform2.Left || enemy1.Left + enemy1.Width > platform2.Left + platform2.Width)
            {
                enemy1Speed = -enemy1Speed;
            }

            if (platformstar_move == true)
            {
                platformstar.Top -= platformSpeed;
            }
            else if (platformstar_move == false)
            {
                platformstar.Top += platformSpeed;
            }

            if (platformstar.Top < star.Bottom + 40)
            {
                platformstar_move = false;
            }

            if (platformstar.Top > platform2.Top + 20)
            {
                platformstar_move = true;
            }

            if (player.Top > 523)
            {
                gametimer.Stop();
                IsGameOver = true;
                label1.Text = "Tu as perdu ! Appuie sur Entrer pour rejouer...";
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                        {

                            gravity = 8;
                            player.Top = x.Top - player.Height;
                            jumpSpeed = 0;
                        }

                        x.BringToFront();
                    }
                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            if (player.Bottom -1 ==  x.Top)
                            {
                                x.Visible = false;
                            } else
                            {
                                Console.WriteLine(x.Top);
                                Console.WriteLine(player.Bottom);
                                gametimer.Stop();
                                IsGameOver = true;
                                label1.Text = "Tu as perdu ! Appuie sur Entrée pour rejouer...";
                            }
                        }
                    }
                    if ((string)x.Tag == "fruits")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score += 10;
                            label3.Text = "Score : " + score.ToString();
                        }
                    }
                    if ((string)x.Tag == "star")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gametimer.Stop();
                            IsGameOver = true;
                            label1.Text = "Tu as Gagné ! Appuie sur Entrée pour rejouer...";
                        }
                    }
                    if ((string)x.Tag == "fire")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (player.BackColor == Color.Red)
                            {

                            }
                            else
                            {
                                gametimer.Stop();
                                IsGameOver = true;
                                label1.Text = "Tu as perdu ! Appuie sur Entrée pour rejouer...";

                            }
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Q)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && !jumping || e.KeyCode == Keys.Z && !jumping)
            {
                jumping = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                characterSkin += 1;

                if (characterSkin == 1)
                {
                    playerSpeed = 10;
                    enemy1Speed = enemy1Speed / 3;
                    player.BackColor = Color.White;
                }
                if (characterSkin == 2)
                {
                    enemy1Speed = 3;
                    player.BackColor = Color.Red;
                }
                if (characterSkin == 3)
                {
                    player.BackColor = Color.DarkBlue;
                    characterSkin = 0;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Q)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.F1 && Menu == false)
            {
                gametimer.Stop();
                label5.Visible = true;
                Menu = true;
            } else if (e.KeyCode == Keys.F1 && Menu == true)
            {
                gametimer.Start();
                label5.Visible=false;
                Menu = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && IsGameOver == true || e.KeyCode == Keys.Z && IsGameOver == true)
            {
                label1.Text = "";
                ResetGame();
            }
            if (e.KeyCode == Keys.C && Hard == false)
            {
                enemy1Speed = enemy1Speed * 2;
                enemy1.Top = enemy1.Top - 40;
                platformSpeed = platformSpeed * 3;
                enemy1.Height = enemy1.Height * 2;
                Hard = true;
            } else if (e.KeyCode == Keys.C && Hard == true)
                    {
                enemy1Speed = enemy1Speed / 2;
                enemy1.Top = enemy1.Top + 40;
                platformSpeed = platformSpeed / 3;
                enemy1.Height = enemy1.Height / 2;
                Hard = false;
            }
        }

        private void ResetGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            IsGameOver = false;
            Menu = false;
            platformstar_move = true;
            characterSkin = 0;
            time = 0;
            score = 0;
            label3.Text = "Score : 0";
            label4.Text = "Temps :" + time.ToString() + "s";

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            player.Left = 24;
            player.Top = 372;

            gametimer.Start();
        }
    }
}
