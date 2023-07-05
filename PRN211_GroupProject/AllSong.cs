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
    public partial class AllSong : Form
    {
        private Form previous;
        private SongService songService;
        private PlayListService playListService;
        private PlayListSongService playListSongService;

        private List<Song> songs;
        private List<PlayList> playlists;
        private int curSong = 0;
 
        public AllSong()
        {
            InitializeComponent();
            //this.previous = previous;
            songService = SongService.gI();
            playListService = PlayListService.gI();
            playListSongService = PlayListSongService.gI();

            songs = songService.getALlSong();
        }

        public bool condition()
        {
            if (curSong >= songs.Count)
            {
                lbSongNameValue.Text = "";
                lbSingerValue.Text = "";
                lbYOPValue.Text = "";
                cbPlayList.DataSource = new List<string>();
                lbPlay.Enabled = false;
                btnAddToPlayList.Enabled = false;
                return false;
            }
            lbPlay.Enabled = true;
            btnAddToPlayList.Enabled = true;
            return true;
        }

        public void loadPlayListBySong()
        {
            if (!condition()) return;
            Song song = songs[curSong];
            lbSongNameValue.Text = song.name;
            lbSingerValue.Text = song.singer;
            lbYOPValue.Text = song.YOP.ToString();

            List<PlayListSong> pls = playListSongService.getBySongId(song.id);
            List<int> plId = new List<int>();
            foreach(var p in pls)
            {
                plId.Add(p.play_list_id);
            }
            playlists = playListService.getAllPlayList()
                .Where(p => plId
                .IndexOf(p.id) == -1)
                .ToList();
            
            List<string> listString = new List<string>();
            foreach(var p in playlists)
            {
                listString.Add(p.name);
            }

            cbPlayList.DataSource = listString;
            cbPlayList.Text = "";
            lbPlay.Enabled = true;
            btnAddToPlayList.Enabled = true;
        }

        private void AllSong_Load(object sender, EventArgs e)
        {
            dgvListSong.DataSource = new BindingSource() { DataSource = songs };
            loadPlayListBySong();
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void dgvListSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            curSong = e.RowIndex;
            loadPlayListBySong();
        }

        private void lbPlay_Click(object sender, EventArgs e)
        {
            if (!condition())
            {
                MessageBox.Show("List Of song is empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SongPlayer songPlayer = new SongPlayer(this, songs[curSong]);
            this.Hide();
            songPlayer.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            curSong = 0;
            string searchValue = txtSearchBar.Text.Trim().ToLower();
            List<Song> newSongs = songService.getALlSong();
            songs = newSongs
                .Where(s => s.name.ToLower().Contains(searchValue) || s.singer.ToLower().Contains(searchValue))
                .ToList();
            dgvListSong.DataSource = new BindingSource() { DataSource = songs };
            loadPlayListBySong();
        }

        private void btnAddToPlayList_Click(object sender, EventArgs e)
        {
            int index = cbPlayList.SelectedIndex;
            PlayList playList = playlists[index];
            Song song = songs[curSong];
            PlayListSong playListSong = new PlayListSong(playList.id, song.id);
            playListSongService.save(playListSong);
            loadPlayListBySong();
            MessageBox.Show("Add to playlist successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
