namespace Jump
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.Prompt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fire = new System.Windows.Forms.PictureBox();
            this.star = new System.Windows.Forms.PictureBox();
            this.platformstar = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fruits = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformstar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tag = "gametimer";
            this.gametimer.Tick += new System.EventHandler(this.Main_Game);
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.Location = new System.Drawing.Point(543, 95);
            this.Prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(0, 70);
            this.Prompt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 5;
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.Color.Red;
            this.fire.Location = new System.Drawing.Point(783, 261);
            this.fire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(44, 181);
            this.fire.TabIndex = 8;
            this.fire.TabStop = false;
            this.fire.Tag = "fire";
            // 
            // star
            // 
            this.star.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.star.Location = new System.Drawing.Point(987, 84);
            this.star.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(41, 49);
            this.star.TabIndex = 7;
            this.star.TabStop = false;
            this.star.Tag = "star";
            // 
            // platformstar
            // 
            this.platformstar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platformstar.Location = new System.Drawing.Point(861, 412);
            this.platformstar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.platformstar.Name = "platformstar";
            this.platformstar.Size = new System.Drawing.Size(265, 30);
            this.platformstar.TabIndex = 6;
            this.platformstar.TabStop = false;
            this.platformstar.Tag = "platform";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Pink;
            this.enemy1.Enabled = false;
            this.enemy1.Location = new System.Drawing.Point(672, 412);
            this.enemy1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(44, 49);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform2.Location = new System.Drawing.Point(451, 458);
            this.platform2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(265, 30);
            this.platform2.TabIndex = 2;
            this.platform2.TabStop = false;
            this.platform2.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DarkBlue;
            this.player.Location = new System.Drawing.Point(32, 469);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(41, 49);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform1.Location = new System.Drawing.Point(32, 539);
            this.platform1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(265, 30);
            this.platform1.TabIndex = 0;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1093, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            this.label2.Tag = "Score";
            // 
            // fruits
            // 
            this.fruits.BackColor = System.Drawing.Color.Green;
            this.fruits.Location = new System.Drawing.Point(230, 496);
            this.fruits.Margin = new System.Windows.Forms.Padding(4);
            this.fruits.Name = "fruits";
            this.fruits.Size = new System.Drawing.Size(21, 22);
            this.fruits.TabIndex = 10;
            this.fruits.TabStop = false;
            this.fruits.Tag = "fruits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 54);
            this.label3.TabIndex = 11;
            this.label3.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(468, 428);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "fruits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1156, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fruits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.star);
            this.Controls.Add(this.platformstar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Jump";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformstar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox platformstar;
        private System.Windows.Forms.PictureBox star;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fruits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

