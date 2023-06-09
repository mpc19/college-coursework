
namespace dropbox
{
    partial class Environment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Environment));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.difficultyTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_settings = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.powerupLabel = new System.Windows.Forms.Label();
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.powerup = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.extra2 = new System.Windows.Forms.PictureBox();
            this.extra1 = new System.Windows.Forms.PictureBox();
            this.platform7 = new System.Windows.Forms.PictureBox();
            this.platform6 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform5 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.counter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.powerup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(767, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(123, 36);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 90";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 14;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // startTimer
            // 
            this.startTimer.Enabled = true;
            this.startTimer.Interval = 600;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // difficultyTimer
            // 
            this.difficultyTimer.Enabled = true;
            this.difficultyTimer.Interval = 12000;
            this.difficultyTimer.Tick += new System.EventHandler(this.difficultyTimer_Tick);
            // 
            // btn_settings
            // 
            this.btn_settings.Enabled = false;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_settings.Location = new System.Drawing.Point(70, 12);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(125, 42);
            this.btn_settings.TabIndex = 7;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Visible = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // quitButton
            // 
            this.quitButton.Enabled = false;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.quitButton.Location = new System.Drawing.Point(201, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(125, 42);
            this.quitButton.TabIndex = 7;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Visible = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // powerupLabel
            // 
            this.powerupLabel.AutoSize = true;
            this.powerupLabel.BackColor = System.Drawing.Color.Transparent;
            this.powerupLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerupLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.powerupLabel.Location = new System.Drawing.Point(692, 45);
            this.powerupLabel.Name = "powerupLabel";
            this.powerupLabel.Size = new System.Drawing.Size(198, 36);
            this.powerupLabel.TabIndex = 8;
            this.powerupLabel.Text = "Powerup: None";
            // 
            // gravityTimer
            // 
            this.gravityTimer.Interval = 5000;
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // powerup
            // 
            this.powerup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(115)))));
            this.powerup.Location = new System.Drawing.Point(414, 411);
            this.powerup.Name = "powerup";
            this.powerup.Size = new System.Drawing.Size(13, 15);
            this.powerup.TabIndex = 6;
            this.powerup.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(237)))), ((int)(((byte)(117)))));
            this.player.Location = new System.Drawing.Point(51, 432);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(40, 40);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // extra2
            // 
            this.extra2.BackColor = System.Drawing.Color.White;
            this.extra2.Location = new System.Drawing.Point(859, 321);
            this.extra2.Name = "extra2";
            this.extra2.Size = new System.Drawing.Size(300, 15);
            this.extra2.TabIndex = 3;
            this.extra2.TabStop = false;
            // 
            // extra1
            // 
            this.extra1.BackColor = System.Drawing.Color.White;
            this.extra1.Location = new System.Drawing.Point(1259, 342);
            this.extra1.Name = "extra1";
            this.extra1.Size = new System.Drawing.Size(300, 15);
            this.extra1.TabIndex = 3;
            this.extra1.TabStop = false;
            // 
            // platform7
            // 
            this.platform7.BackColor = System.Drawing.Color.White;
            this.platform7.Location = new System.Drawing.Point(648, 447);
            this.platform7.Name = "platform7";
            this.platform7.Size = new System.Drawing.Size(300, 15);
            this.platform7.TabIndex = 3;
            this.platform7.TabStop = false;
            // 
            // platform6
            // 
            this.platform6.BackColor = System.Drawing.Color.White;
            this.platform6.Location = new System.Drawing.Point(1678, 508);
            this.platform6.Name = "platform6";
            this.platform6.Size = new System.Drawing.Size(300, 15);
            this.platform6.TabIndex = 3;
            this.platform6.TabStop = false;
            // 
            // platform4
            // 
            this.platform4.BackColor = System.Drawing.Color.White;
            this.platform4.Location = new System.Drawing.Point(773, 390);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(300, 15);
            this.platform4.TabIndex = 3;
            this.platform4.TabStop = false;
            // 
            // platform5
            // 
            this.platform5.BackColor = System.Drawing.Color.White;
            this.platform5.Location = new System.Drawing.Point(1053, 351);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(300, 15);
            this.platform5.TabIndex = 3;
            this.platform5.TabStop = false;
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.White;
            this.platform3.Location = new System.Drawing.Point(1472, 468);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(300, 15);
            this.platform3.TabIndex = 3;
            this.platform3.TabStop = false;
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.White;
            this.platform2.Location = new System.Drawing.Point(287, 432);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(300, 15);
            this.platform2.TabIndex = 3;
            this.platform2.TabStop = false;
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.White;
            this.platform1.Location = new System.Drawing.Point(-1, 493);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(300, 15);
            this.platform1.TabIndex = 3;
            this.platform1.TabStop = false;
            // 
            // background
            // 
            this.background.Image = global::Dropbox.Properties.Resources.universe1;
            this.background.Location = new System.Drawing.Point(-27, -3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(958, 590);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 9;
            this.background.TabStop = false;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.BackColor = System.Drawing.Color.Transparent;
            this.counter.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.ForeColor = System.Drawing.SystemColors.Control;
            this.counter.Location = new System.Drawing.Point(834, 81);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(56, 36);
            this.counter.TabIndex = 8;
            this.counter.Text = "0/1";
            // 
            // Environment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(924, 581);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.powerupLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.powerup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.extra2);
            this.Controls.Add(this.extra1);
            this.Controls.Add(this.platform7);
            this.Controls.Add(this.platform6);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Environment";
            this.Text = "8QY62eFa2E+mpdmyBJtrrA==";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Environment_FormClosed);
            this.Load += new System.EventHandler(this.Environment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Environment_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.powerup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox platform5;
        private System.Windows.Forms.PictureBox platform6;
        private System.Windows.Forms.PictureBox platform4;
        private System.Windows.Forms.PictureBox platform7;
        private System.Windows.Forms.PictureBox extra1;
        private System.Windows.Forms.PictureBox extra2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Timer difficultyTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox powerup;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label powerupLabel;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label counter;

    }
}