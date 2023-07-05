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
    public partial class MyPlaylist : Form
    {
        PlayListService _playlist;
        PlayListSongService _playlistSong;
        SongService _song;

        private List<PlayList> playlists;

        private PlayList playlist;
        private List<Song> songs;

        public MyPlaylist()
        {
            InitializeComponent();
            _playlist = PlayListService.gI();
            _playlistSong = PlayListSongService.gI();
            _song = SongService.gI();
            reload();

        }

        public void reload()
        {
            playlists = _playlist.getAllPlayList();
            if (playlists.Count > 0) playlist = playlists[0];

            dgvPlaylist.Columns.Add("ID", "ID");
            dgvPlaylist.Columns.Add("Name", "Name");
            dgvPlaylist.Columns.Add("Created", "Created At");
            dgvPlaylist.Columns.Add("Description", "Description");
            dgvPlaylist.Columns["ID"].Width = 50;
            dgvPlaylist.Columns["Description"].Width = 158;

            dgvPlaylist.Rows.Clear();
            foreach (var item in playlists)
            {
                dgvPlaylist.Rows.Add(item.id, item.name, item.createdAt, item.description);
            }
            btnPlay.Enabled = false;
            btnRemovePlaylist.Enabled = false;
            btnRemoveSong.Enabled = false;
        }

        private void dgvPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            playlist = playlists[rowIndex];

            lbShowName.Text = playlist.name;
            lbShowCreate.Text = playlist.createdAt.ToString();
            loadSongInPlaylist();

            btnPlay.Enabled = true;
            btnRemovePlaylist.Enabled = true;
            btnRemoveSong.Enabled = true;
        }

        public void loadSongInPlaylist()
        {
            if (playlist == null) return;
            lbShowName.Text = playlist.name;
            lbShowCreate.Text = playlist.createdAt.ToString();
            songs = new List<Song>();
            List<PlayListSong> pls = _playlistSong.getByPlayListId(playlist.id);
            List<string> lbox = new List<string>();
            foreach (var p in pls)
            {
                Song song = _song.getById(p.song_id);
                songs.Add(song);
                lbox.Add(string.Format("{0}. {1}", song.id, song.name));
            }
            lstListSongs.DataSource = new BindingSource() { DataSource = lbox };
            lbShowNumber.Text = songs.Count.ToString();
        }

        private void MyPlaylist_Load(object sender, EventArgs e)
        {
            loadSongInPlaylist();
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lstListSongs.SelectedIndex;
                Song song = songs[index];
                _playlistSong.delete(playlist.id, song.id);
                loadSongInPlaylist();
            }
            catch
            {
                MessageBox.Show("Please select song to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRemovePlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Song song in songs)
                {
                    _playlistSong.delete(playlist.id, song.id);
                }
                _playlist.delete(playlist.id);
                reload();
            }
            catch
            {
                MessageBox.Show("Please select playlist to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            var finded = playlists.FindAll(p => p.name.ToLower().Contains(searchValue.ToLower()));
            if (finded.Count > 0)
            {
                dgvPlaylist.Rows.Clear();
                foreach (var item in finded)
                {
                    dgvPlaylist.Rows.Add(item.id, item.name, item.createdAt, item.description);
                }
            }
            else
            {
                MessageBox.Show("Cannot find the result!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }


    }
}
