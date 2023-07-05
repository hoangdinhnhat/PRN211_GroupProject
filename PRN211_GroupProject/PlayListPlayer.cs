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
    public partial class PlayListPlayer : Form
    {
        private PlayList playList;
        private List<Song> songs;
        private int currentSongIndex;
        public PlayListPlayer()
        {
            InitializeComponent();
        }

        private void PlayListPlayer_Load_1(object sender, EventArgs e)
        {
            List<PlayList> playList = PlayListService.gI().getByUser("hdnqt");
            List<string> list = new List<string>();
            foreach (PlayList item in playList)
            {
                list.Add(item.name);
            }
            lboxSongs.DataSource = list;
        }
    }
}
