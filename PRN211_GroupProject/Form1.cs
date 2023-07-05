using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PRN211_GroupProject.Utils;
using PRN211_GroupProject.Model;
using PRN211_GroupProject.Repository;
using PRN211_GroupProject.Service;

namespace PRN211_GroupProject
{
    public partial class Form1 : Form
    {

        private UserService userService;
        private SongService songService;
        private PlayListService playListService;

        public Form1()
        {
            InitializeComponent();
            userService = UserService.gI();
            songService = SongService.gI();
            playListService = PlayListService.gI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Song> songs = songService.getALlSong();
            dgvTest.DataSource = new BindingSource() { DataSource = songs };
        }

        private void dgvTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Song> songs = songService.getALlSong();
            int rowIndex = e.RowIndex;
            Song song = songs[rowIndex];
            wmplayer.URL = song.path;
        }
    }
}
