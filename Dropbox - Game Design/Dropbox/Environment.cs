using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace dropbox
{
    public partial class Environment : Form
    {

        // Easy way to get back to an unchanged main menu
        private Main main;

        // The theme of the environment
        private Theme theme = Theme.NONE;


        // Is the game paused?
        Boolean paused = false;

         // PLAYER //
        // Is the player on ground currently, was the player on ground last update?
        Boolean onGround = false, wasOnGround = false;

        // Default gravity value, current gravity value, friction which isn't used, the current x velocity, current y, how much y does a jump apply?
        private double defaultGravity = 0.07, gravity = 0.07, friction = 0.18, curVelX = 0, curVelY = 0, jumpVel = 9, bounciness = 0.021;
        private int velX = 6, velY = 11;

        private List<PowerUp> powerups = new List<PowerUp>();
        private PowerUp pup;

        int score, FormWidth;

        private PictureBox lastCollided;

        Random random = new Random();



        int speed = 1, cur = 0;
        List<PictureBox> platforms = new List<PictureBox>();

        public Environment()
        {
            InitializeComponent();
        }

        private void Environment_Load(object sender, EventArgs e)
        {
            updateTimer.Interval = Convert.ToInt32(1000 / main.getRefreshRate());

            // Add the platforms to a collection for easy modification & handling
            platforms.Add(platform1);
            platforms.Add(platform2);
            platforms.Add(platform3);
            platforms.Add(platform4);
            platforms.Add(platform5);
            platforms.Add(platform6);
            platforms.Add(platform7);
            platforms.Add(extra1);
            platforms.Add(extra2);

            theme = main.getSettings().getTheme();

            switch (theme)
            {
                case Theme.NONE:
                    background.Visible = false;
                    background.Dispose();
                    break;
                case Theme.SPACE:
                    background.Image = Dropbox.Properties.Resources.universe1;
                    using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.eery))
                    {
                        Task.Factory.StartNew(() =>  soundPlayer.PlaySync()); // can also use soundPlayer.PlaySync()
                    }
                    break;
                case Theme.WATER:
                    background.Image = Dropbox.Properties.Resources.sea;
                    using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.water))
                    {
                        Task.Factory.StartNew(() => soundPlayer.PlaySync()); // can also use soundPlayer.PlaySync()
                    }
                    break;      
            }

            FormWidth = Width;
            // Set the starting speed to option in setting
            speed = main.getSettings().getStartingDifficulty();

            // Enable the game loop timer
            updateTimer.Enabled = true;
            player.SetBounds(player.Bounds.X, player.Bounds.Y, player.Bounds.Width, player.Bounds.Height - 1);

        }

        private void addPowerup(PowerUp powerUp)
        {
            if (powerups.Count > 1)
            {
                powerups.Add(powerUp);
            }
            else
            {
                powerups.Add(pup = powerUp);
                powerupLabel.Text = "Powerup: " + fixCasing(pup.ToString());
            }
            updateCounter();
        }

        private void updateCounter()
        {
            if (powerups.Count > 0)
            {
                counter.Text = "1/" + powerups.Count;
            }
            else
            {
                counter.Text = "0/0";
            }
        }

        private void Environment_FormClosed(object sender, FormClosedEventArgs e)
        {
            powerups.Clear();
            platforms.Clear();
            lastCollided = null;

            main.Show();
            main = null;
            Dispose();

            // Force memory to be cleared as we create a new form each game
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        internal void setParent(Main main)
        {
            this.main = main;
        }

        // the game loop
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            // Updates the players movement; friction gravity.
            updatePlayer();

            // Move the powerup after the player has been updated to keep alligned with the platforms
            powerup.Left -= speed;
            powerup.Top += Convert.ToInt32(curVelY);

            // Computers cannot handle this
            //background.Top += Convert.ToInt32(curVelY);

            // update the platforms to create the game..
            foreach(PictureBox p in platforms) {
                p.Left -= speed;
                updatePanel(p);
            }
        }

        private void updatePlayer()
        {
            if (player.Bottom > Height)
            {
                updateTimer.Stop();
                startTimer.Stop();
                using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.lose))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }

                MessageBox.Show("You died! Score of " + score);

                main.submitScore(score);
                Close();
                Dispose();
            }

            if (player.Right > Width - 7)
            {
                curVelX = 0;
            }

            if (player.Left < 0)
            {
                curVelX = 0;
            }

            if (curVelX != 0)
            {
                if (curVelX > 0)
                {
                    curVelX -= (velX / 4) * friction;
                    curVelX = Math.Max(0, curVelX);
                    player.Left += Convert.ToInt16(curVelX);
                }
                else
                {
                    curVelX += (velX / 4) * friction;
                    curVelX = Math.Min(0, curVelX);
                    player.Left += Convert.ToInt16(curVelX);
                }
            }


            if (!onGround)
            {
                curVelY -= (velY / 2) * gravity;
                player.Top -= Convert.ToInt16(curVelY);
            }


            if (curVelY < -20)
            {
                curVelY = -20;
            }

            int id = 0;

            // reset to make sure the player is on ground
            onGround = false;
            foreach (PictureBox pb in platforms)
            {
                id++;
                if (player.Bounds.IntersectsWith(pb.Bounds))
                {
                    lastCollided = pb;
                    if (player.Top > pb.Top)
                    {
                        curVelY = -(jumpVel * bounciness);
                        return;
                    }

 

                    onGround = true;
                    if (player.Bottom > pb.Top)
                    {
                        player.Top = (pb.Top - player.Height + 2);
                    }

                    curVelY = 0;
                    break;
                }

                // clear the last collided to prevent issues
                lastCollided = null;
            }

            // this is to check they have started to collide with the ground in which the sound will only play once.
            if (onGround && !wasOnGround)
            {
                    using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.bonk))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
            }

            // checks if the player collects a double jump
            if (powerup.Visible && player.Bounds.IntersectsWith(powerup.Bounds))
            {
                addPowerup((PowerUp)Enum.GetValues(typeof(PowerUp)).GetValue(random.Next(0, 3)));
                
                using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.coin_1))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }
                powerup.Visible = false;
            }

            wasOnGround = onGround;

        }

        private void updatePanel(PictureBox p)
        {

            p.Top += Convert.ToInt32(curVelY);
            
            if (p.Left + p.Width < 0)
            {

                p.Left = FormWidth;

                p.Width = random.Next(Main.settings.getMinLength(), Main.settings.getMaxLength());
                p.Top += random.Next(-20, 20);

                if (!powerup.Visible)
                {
                    if (random.NextDouble() <= 0.24)
                    {
                        powerup.Top = p.Top - (p.Height + 1);
                        powerup.Left = FormWidth;
                        powerup.Visible = true;
                    }
                }
                else
                {
                    if (powerup.Visible && powerup.Left + p.Width < 0)
                    {
                        powerup.Visible = false;
                    }
                }
            }
        }

        private void difficultyTimer_Tick(object sender, EventArgs e)
        {
            speed++;
            startTimer.Interval = Convert.ToInt32(startTimer.Interval * 0.8);
            difficultyTimer.Interval = Convert.ToInt32(difficultyTimer.Interval * 1.8);
        }

        private void Environment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && powerups.Count > 0)
            {
                if (pup == PowerUp.SLOW)
                {
                    if (speed > 1)
                    {
                        speed -= 1;
                        removePowerup();
                        using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.slowed))
                        {
                            soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                        }
                    }
                }
                else if (pup == PowerUp.GRAVITY)
                {
                    if (!gravityTimer.Enabled)
                    {
                        gravity = 0.035;
                        gravityTimer.Enabled = true;
                        removePowerup();
                        using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.gravity))
                        {
                            soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                        }
                    }
                }

            }


            if (onGround && (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.W))
            {
                curVelY += jumpVel;
                onGround = false;
                using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.jump))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }     
            }
            else
            {
                if (powerups.Count > 0 && pup == PowerUp.JUMP && !onGround && (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.W))
                {
                    removePowerup();
                    curVelY = jumpVel;
                    using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.jump))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                paused = !paused;
                if (paused)
                {
                    pictureBox1.Image = Dropbox.Properties.Resources.play;
                    updateTimer.Stop();
                    difficultyTimer.Stop();
                    startTimer.Stop();
                }
                else
                {
                    pictureBox1.Image = Dropbox.Properties.Resources.pause;
                    updateTimer.Start();
                    startTimer.Start();
                    difficultyTimer.Start();
                }
            }
        }

        private void removePowerup()
        {
            if (powerups.Count > 0)
            {
                powerups.RemoveAt(0);
                if (powerups.Count > 0)
                {
                    pup = powerups[0];
                    powerupLabel.Text = "Powerup: " + fixCasing(pup.ToString());
                }
                else
                {
                    powerupLabel.Text = "Powerup: None";
                }
            }
            updateCounter();
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            score++;
            scoreLabel.Text = "Score: " + score;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            paused = !paused;
            if (paused)
            {
                pictureBox1.Image = Dropbox.Properties.Resources.play;
                updateTimer.Stop();
                difficultyTimer.Stop();
                startTimer.Stop();
                btn_settings.Visible = true;
                btn_settings.Enabled = true;
                quitButton.Visible = true;
                quitButton.Enabled = true;
            }
            else
            {
                pictureBox1.Image = Dropbox.Properties.Resources.pause;
                updateTimer.Start();
                startTimer.Start();
                difficultyTimer.Start();
                btn_settings.Visible = false;
                btn_settings.Enabled = false;
                quitButton.Visible = false;
                quitButton.Enabled = false;
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            main.getSettings().Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            gravityTimer.Enabled = false;
            gravity = defaultGravity;
        }

        internal String fixCasing(String s)
        {
          return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }

    }

    public enum Theme
    {
        NONE, WATER, SPACE
    }

    enum PowerUp {
        JUMP, GRAVITY, SLOW
    }
}
