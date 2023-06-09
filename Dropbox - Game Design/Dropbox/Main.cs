using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Dropbox.Util;
using System.Media;
using Dropbox.Forms;
using Dropbox.Misc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace dropbox
{
    public partial class Main : Form
    {
        //public AchievementManager achievementManager;

        private Form startingForm;

        bool started = true;
        public static Dictionary<String, int> leaderboard = new Dictionary<string, int>();
        private List<Item> spawnedItems = new List<Item>();

        public static MusicPlayer mp;
        public static Settings settings;

        int refreshRate = 75;

        private Item lastSpawned;
        private static Environment environmentForm;

        int mouseX = 9999, mouseY = 9999, deltaMouseX, deltaMouseY, item = 1;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // define the starting form so we can use in future, whether closing other forms.
            startingForm = this;

            // check if the folder exists
            if (!Directory.Exists("dropbox inc"))
            {
                // if not create
                Directory.CreateDirectory("dropbox inc");
            }

            // check if the leaderboard file exists
            if (!File.Exists("dropbox inc/highscore.db"))
            {
                // if not create
                File.Create("dropbox inc/highscore.db");
                leaderboardLabel.Text = "None";
            }
            else
            {
                String[] loaded = File.ReadAllLines("dropbox inc/highscore.db");
                foreach(String s in loaded) {
                    String[] split = s.Split(new char[] { ':' });
                    leaderboard.Add(split[0], Convert.ToInt16(split[1]));
                }

                updateLeaderboard();
            }

            if (!File.Exists("changelog.txt"))
            {
                changelogLabel.Text += "\n" + "Not available!";
            }
            else
            {
                String[] loaded = File.ReadAllLines("changelog.txt");
                foreach (String s in loaded)
                {
                    changelogLabel.Text += "\n" + s;
                }
            }

            // make a variable called settings so we can use it globally through all forms
            settings = new Settings(this);


			// We'll make this a setting so, if people want to listen to the two songs they can enable it in settings.
            //mp = new MusicPlayer(this);
            //mp.Show();

            // Old idea left overs
            panel_environment.Enabled = false;
            panel_environment.Visible = false;
           // spawnedItems.Add(new Item(panel_mainMenu, pb_logo, false));

            // run the loop for the main menu minigame
            timer_update.Start();
            started = true;
        }

        internal int getRefreshRate()
        {
            return refreshRate;
        }

        internal Button GetSettingButton()
        {
            return btn_settings;
        }

        public void updateLeaderboard()
        {
            if (leaderboard.Count > 0)
            {
                int i = 0;
                leaderboardLabel.Text = "";
                var sorted = leaderboard.OrderByDescending(x => x.Value);
                foreach (var key in sorted)
                {
                    i++;
                    leaderboardLabel.Text += i + ". " + key + "\n";
                }
            }
            else
            {
                leaderboardLabel.Text = "None.";
            }
        }

        public void saveScores()
        {
            List<String> scores = new List<string>();
            int index = 0;
            foreach (String s in leaderboard.Keys)
            {
                scores.Add(s + ":" + leaderboard[s]);
                index++;
            }

            File.WriteAllLines("dropbox inc/highscore.db", scores);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.ok))
            {
                soundPlayer.Play();
            }

            started = true;

            panel_environment.Enabled = true;
            panel_environment.Visible = true;

            this.Hide();

            environmentForm = new Environment();
            environmentForm.setParent(this);
            environmentForm.Show();
        }

        internal void setRefreshRate(int v)
        {
            this.refreshRate = v;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (mp != null)
            {
                mp.cancelSource.Cancel();
                mp.Close();
                mp.Dispose();
            }

            // exit :D
            Close();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (started)
            {
                // This'll force update the mouse because its impossible to be near 9,000
                if (mouseX == 9999)
                {
                    mouseX = e.X;
                    mouseY = e.Y;
                    return;
                }
                else
                {
                    mouseY = e.Y;
                    mouseX = e.X;
                }
            }
        }

        internal static Environment GetEnvironment()
        {
            // return a single defined form
            return environmentForm;
        }

        private void panel_environment_MouseMove(object sender, MouseEventArgs e)
        {
            Main_MouseMove(sender, e);
        }

        private void explosionButton_Click(object sender, EventArgs e)
        {
            if (lastSpawned != null)
            {
                lastSpawned.explode(spawnedItems, 300);
            }
        }

        private void panel_mainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            Main_MouseMove(sender, e);
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            foreach(Item i in spawnedItems)
            {
                if(i.hasGravity())
                {
                    i.update();
                }

                if (i.hasCollisions())
                {
                    i.checkBounds();
                }
            }
        }

        private void panel_environment_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pb = new PictureBox {
                Image = Dropbox.Properties.Resources.dirt,
                Name = "dirt_" + item,
                Size = new System.Drawing.Size(16, 16),
                Location = new System.Drawing.Point(e.X - 8, e.Y - 8)
            };
            item++;
            

            panel_mainMenu.Controls.Add(pb);
            Item i = lastSpawned = new Item(panel_environment, pb, true);
            i.setVelocity(deltaMouseX, deltaMouseY);
            spawnedItems.Add(i);

            if(spawnedItems.Count > 20)
            {
                spawnedItems[0].destroy();
                spawnedItems.RemoveAt(0);
            }
        }



        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseX == 9999)
            {
                mouseX = e.X;
                mouseY = e.Y;
                return;
            }
            else
            {
                foreach (Item i in spawnedItems)
                {
                    if (i.isDragged())
                    {
                        i.getOwner().Left += (e.X - mouseX);
                        i.getOwner().Top += (e.Y - mouseY);
                    }
                }

                deltaMouseX = (e.X - mouseX);
                deltaMouseY = (e.Y - mouseY);
                mouseY = e.Y;
                mouseX = e.X;
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (!settings.Visible)
            {
                settings.Show();
                btn_settings.Enabled = false;
            }
        }

        internal Settings getSettings()
        {
            return settings;
        }

        internal MusicPlayer getMusicPlayer()
        {
            return mp;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            saveScores();
            // start a locally defined sound as we dont need to keep it
            using (var soundPlayer = new SoundPlayer(Dropbox.Properties.Resources.cancel))
            {
                // Use a new thread to prevent freezing, it technically shouldn't anyway so this is an unintended bug
               Task.Factory.StartNew(() => soundPlayer.PlaySync()); // can also use soundPlayer.PlaySync()
            }

        }

        internal void submitScore(int score)
        {
            if (leaderboard.ContainsKey(Main.settings.getName()))
            {
                if (leaderboard[Main.settings.getName()] < score)
                {
                    leaderboard.Remove(Main.settings.getName());
                    leaderboard.Add(Main.settings.getName(), score);
                }
            }
            else
            {
                leaderboard.Add(Main.settings.getName(), score);
            }
                updateLeaderboard();

        }


        internal void setMusicPlayer(MusicPlayer musicPlayer)
        {
            mp = musicPlayer;
        }
    }
}
