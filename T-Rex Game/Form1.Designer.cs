
namespace T_Rex_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.floor = new System.Windows.Forms.PictureBox();
            this.secondeObstacle = new System.Windows.Forms.PictureBox();
            this.Obstacle = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondeObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(-8, 411);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(816, 49);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // secondeObstacle
            // 
            this.secondeObstacle.Image = global::T_Rex_Game.Properties.Resources.obstacle_2;
            this.secondeObstacle.Location = new System.Drawing.Point(613, 378);
            this.secondeObstacle.Name = "secondeObstacle";
            this.secondeObstacle.Size = new System.Drawing.Size(32, 33);
            this.secondeObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.secondeObstacle.TabIndex = 1;
            this.secondeObstacle.TabStop = false;
            this.secondeObstacle.Tag = "obstacle";
            // 
            // Obstacle
            // 
            this.Obstacle.Image = global::T_Rex_Game.Properties.Resources.obstacle_1;
            this.Obstacle.Location = new System.Drawing.Point(465, 365);
            this.Obstacle.Name = "Obstacle";
            this.Obstacle.Size = new System.Drawing.Size(23, 46);
            this.Obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle.TabIndex = 1;
            this.Obstacle.TabStop = false;
            this.Obstacle.Tag = "obstacle";
            // 
            // trex
            // 
            this.trex.Image = global::T_Rex_Game.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(103, 368);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            this.trex.Tag = "T-Rex";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Consolas", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(28, 25);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(159, 36);
            this.scoreText.TabIndex = 2;
            this.scoreText.Tag = "scoreText";
            this.scoreText.Text = "Score = 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tag = "gameTimer";
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.Obstacle);
            this.Controls.Add(this.secondeObstacle);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "T-Rex Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondeObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox secondeObstacle;
        private System.Windows.Forms.PictureBox Obstacle;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

