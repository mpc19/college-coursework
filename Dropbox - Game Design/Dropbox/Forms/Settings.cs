using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dropbox;
using Dropbox.Misc;

namespace Dropbox.Forms
{
    public partial class Settings : Form
    {

        public static Boolean musicEnabled = false, shuffleEnabled = true;
        public static int startingDifficulty = 2, minLength = 55, maxLength = 120;

        public static String name = "User";

        public Theme theme = Theme.NONE;

        private Main parent;

        public Settings(Main m)
        {
            this.parent = m;
            InitializeComponent();
        }

        private void music_chkBoxChanged(object sender, EventArgs e)
        {
            musicEnabled = music_chkBox.Checked;
            if (!musicEnabled)
            {
                parent.getMusicPlayer().cancelSource.Cancel();
                parent.getMusicPlayer().Close();
            }
            else
            {
                if (parent.getMusicPlayer() is null)
                {
                    parent.setMusicPlayer(new MusicPlayer(parent));
                } else if (parent.getMusicPlayer().IsDisposed)
                {
                    parent.getMusicPlayer().songs.Clear();
                    
                }

				parent.getMusicPlayer().Show();
                parent.getMusicPlayer().start();
            }
        }

        private void shuffle_chkBoxChanged(object sender, EventArgs e)
        {
            shuffleEnabled = shuffle_chkBox.Checked;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            difficultyBox.Text = "" + startingDifficulty;
            minWidthBox.Text = "" + minLength;
            maxWidthBox.Text = "" + maxLength;
        }

        private void difficultyBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
               startingDifficulty =  Convert.ToInt16(difficultyBox.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void maxWidthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                maxLength = Convert.ToInt16(maxWidthBox.Text);
                if (maxLength < minLength)
                {
                    maxLength = minLength;
                    maxWidthBox.Text = "" + minLength;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            parent.GetSettingButton().Enabled = true;
            this.Hide();
        }


        public int getMinLength()
        {
            return minLength;
        }

        public Boolean isShuffleEnabled()
        {
            return shuffleEnabled;
        }

        public int getMaxLength()
        {
            return maxLength;
        }

        public int getStartingDifficulty()
        {
            return startingDifficulty;
        }

        internal bool isMusicEnabled()
        {
            return musicEnabled;
        }

        private void minWidthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                minLength = Convert.ToInt16(minWidthBox.Text);
                if (minLength > maxLength)
                {
                    minLength = maxLength;
                    minWidthBox.Text = "" + minLength;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            name = nameInput.Text;
        }

        public String getName()
        {
            return name;
        }

        internal Theme getTheme()
        {
            return theme;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme = (Theme)Enum.GetValues(typeof(Theme)).GetValue(comboBox1.SelectedIndex);
        }

        private void refreshRate_box_selectedIndexChanged(object sender, EventArgs e)
        {
            parent.setRefreshRate(Convert.ToInt32(refreshRate.Text));
        }
    }

}
