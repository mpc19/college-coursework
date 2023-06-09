namespace Dropbox.Misc
{
    partial class MusicPlayer
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
            this.trackLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Location = new System.Drawing.Point(49, 82);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(78, 13);
            this.trackLabel.TabIndex = 0;
            this.trackLabel.Text = "Current Track: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.Location = new System.Drawing.Point(49, 182);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(61, 13);
            this.playLabel.TabIndex = 0;
            this.playLabel.Text = "Is Playing?:";
            this.playLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 386);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.trackLabel);
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicPlayer_FormClosing);
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playLabel;

    }
}