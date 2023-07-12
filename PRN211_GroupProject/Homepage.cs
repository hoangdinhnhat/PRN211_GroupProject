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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAllSongs_Click(object sender, EventArgs e)
        {
            AllSong allSong = new AllSong(this);
            this.Hide();
            allSong.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadSong uploadSong = new UploadSong(this);
            this.Hide();
            uploadSong.Show();
        }

        private void btnShowPlayList_Click(object sender, EventArgs e)
        {
            MyPlaylist myPlaylist = new MyPlaylist(this);
            this.Hide();
            myPlaylist.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreatePlaylist createPlaylist = new CreatePlaylist(this);
            this.Hide();
            createPlaylist.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile(this);
            this.Hide();
            profile.Show();
        }
    }
}
