
namespace dropbox
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_mainMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leaderboardLabel = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.explosionButton = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changelogLabel = new System.Windows.Forms.Label();
            this.panel_environment = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.animation_thread = new System.Windows.Forms.Timer(this.components);
            this.panel_mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_environment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_mainMenu
            // 
            this.panel_mainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_mainMenu.Controls.Add(this.label1);
            this.panel_mainMenu.Controls.Add(this.leaderboardLabel);
            this.panel_mainMenu.Controls.Add(this.pb_logo);
            this.panel_mainMenu.Controls.Add(this.btn_settings);
            this.panel_mainMenu.Controls.Add(this.btn_exit);
            this.panel_mainMenu.Controls.Add(this.explosionButton);
            this.panel_mainMenu.Controls.Add(this.btn_start);
            this.panel_mainMenu.Controls.Add(this.label3);
            this.panel_mainMenu.Controls.Add(this.label2);
            this.panel_mainMenu.Controls.Add(this.changelogLabel);
            this.panel_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_mainMenu.Name = "panel_mainMenu";
            this.panel_mainMenu.Size = new System.Drawing.Size(1449, 692);
            this.panel_mainMenu.TabIndex = 0;
            this.panel_mainMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_environment_MouseClick);
            this.panel_mainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel_mainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_mainMenu_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(951, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leaders:";
            // 
            // leaderboardLabel
            // 
            this.leaderboardLabel.AutoSize = true;
            this.leaderboardLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.leaderboardLabel.Location = new System.Drawing.Point(951, 269);
            this.leaderboardLabel.Name = "leaderboardLabel";
            this.leaderboardLabel.Size = new System.Drawing.Size(108, 28);
            this.leaderboardLabel.TabIndex = 3;
            this.leaderboardLabel.Text = "1. User: 25";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_logo.Image = global::Dropbox.Properties.Resources.logo_removebg_preview;
            this.pb_logo.Location = new System.Drawing.Point(557, 137);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(330, 91);
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // btn_settings
            // 
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_settings.Location = new System.Drawing.Point(661, 286);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(125, 42);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_exit.Location = new System.Drawing.Point(661, 336);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(125, 42);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // explosionButton
            // 
            this.explosionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explosionButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explosionButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.explosionButton.Location = new System.Drawing.Point(1338, 621);
            this.explosionButton.Name = "explosionButton";
            this.explosionButton.Size = new System.Drawing.Size(81, 28);
            this.explosionButton.TabIndex = 0;
            this.explosionButton.Text = "Explode?";
            this.explosionButton.UseVisualStyleBackColor = true;
            this.explosionButton.Click += new System.EventHandler(this.explosionButton_Click);
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_start.Location = new System.Drawing.Point(661, 236);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(125, 42);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(424, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "dropbox is a platformer in which you try to get as far as possible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 100);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keys:\r\n- Space, W or Up Arrow: Jump\r\n- E: Use powerup\r\n- Esc: Pause\r\n";
            // 
            // changelogLabel
            // 
            this.changelogLabel.AutoSize = true;
            this.changelogLabel.BackColor = System.Drawing.Color.Transparent;
            this.changelogLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelogLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.changelogLabel.Location = new System.Drawing.Point(3, 137);
            this.changelogLabel.Name = "changelogLabel";
            this.changelogLabel.Size = new System.Drawing.Size(107, 25);
            this.changelogLabel.TabIndex = 2;
            this.changelogLabel.Text = "Changelog";
            // 
            // panel_environment
            // 
            this.panel_environment.Controls.Add(this.pictureBox1);
            this.panel_environment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_environment.Location = new System.Drawing.Point(0, 0);
            this.panel_environment.Name = "panel_environment";
            this.panel_environment.Size = new System.Drawing.Size(1449, 692);
            this.panel_environment.TabIndex = 2;
            this.panel_environment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_environment_MouseClick);
            this.panel_environment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_environment_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dropbox.Properties.Resources.dirt;
            this.pictureBox1.Location = new System.Drawing.Point(716, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer_update
            // 
            this.timer_update.Interval = 14;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // animation_thread
            // 
            this.animation_thread.Enabled = true;
            this.animation_thread.Interval = 50;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1429, 687);
            this.Controls.Add(this.panel_mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel_mainMenu.ResumeLayout(false);
            this.panel_mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_environment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mainMenu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Panel panel_environment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button explosionButton;
        private System.Windows.Forms.Timer animation_thread;
        private System.Windows.Forms.Label changelogLabel;
        private System.Windows.Forms.Label leaderboardLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

