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
using WMPLib;

namespace PRN211_GroupProject
{
    public partial class PlayListPlayer : Form
    {
        private Form previous;
        private PlayList playList;
        private List<Song> songs;
        private int currentSongIndex = 0;

        public void loadSongInPlayList()
        {
            songs = new List<Song>();
            List<PlayListSong> playListSongs = PlayListSongService.gI().getByPlayListId(playList.id);
            foreach (var item in playListSongs)
            {
                Song song = SongService.gI().getById(item.song_id);
                songs.Add(song);
            }
        }

        public PlayListPlayer(Form previous, PlayList playList)
        {
            this.previous = previous;
            this.playList = playList;

            loadSongInPlayList();
            InitializeComponent();
        }

        private void PlayListPlayer_Load_1(object sender, EventArgs e)
        {
            IWMPPlaylist pl = wpPlayer.playlistCollection.newPlaylist("Playlist");
            List<string> strings = new List<string>();

            foreach (Song song in songs)
            {
                strings.Add(song.name);
                IWMPMedia media = wpPlayer.newMedia(song.path);
                pl.appendItem(media);
            }
            wpPlayer.currentPlaylist = pl;
            lboxSongs.DataSource = strings;

            lbPlayListNameValue.Text = playList.name;
            lbDesValue.Text = playList.description;
            lbCreatedAtValue.Text = playList.createdAt.ToString();

            lbSongNameValue.Text = songs[currentSongIndex].name;
            lbSingerValue.Text = songs[currentSongIndex].singer;
        }

        public void updateSong()
        {
            if (currentSongIndex < songs.Count - 1) { currentSongIndex++; }
            else { currentSongIndex = 0; }
            lboxSongs.SelectedIndex = currentSongIndex;
            lbSongNameValue.Text = songs[currentSongIndex].name;
            lbSingerValue.Text = songs[currentSongIndex].singer;
        }

        private void wpPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                updateSong();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void lboxSongs_Click(object sender, EventArgs e)
        {
            int index = lboxSongs.SelectedIndex;
            while (currentSongIndex != index)
            {
                wpPlayer.Ctlcontrols.next();
                updateSong();
            }
        }
    }
}
