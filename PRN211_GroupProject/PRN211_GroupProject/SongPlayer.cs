using AxWMPLib;
using PRN211_GroupProject.Model;
using PRN211_GroupProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_GroupProject
{
    public partial class SongPlayer : Form
    {
        private Form previous;
        private Song song;
        private bool replay = false;

        public SongPlayer(Form previous, Song song)
        {
            this.previous = previous;
            this.song = song;
            InitializeComponent();
        }

        private void SongPlayer_Load(object sender, EventArgs e)
        {
            wpPlayer.URL = song.path;
            lbSongNameValue.Text = song.name;
            lbSingerValue.Text = song.singer;
            lbRepValue.Text = replay.ToString();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            replay = !replay;
            lbRepValue.Text = replay.ToString();
        }

        private void wpPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (replay)
                {
                    wpPlayer.Ctlcontrols.play();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }
    }
}
