using PRN211_GroupProject.Model;
using PRN211_GroupProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_GroupProject
{
    public partial class UploadSong : Form
    {
        private Form previous;
        private SongService songService;
        private OpenFileDialog openFileDialog;
        private string chooseFile;

        public UploadSong(Form previous)
        {
            this.previous = previous;
            songService = SongService.gI();
            InitializeComponent();
        }

        private void UploadSong_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Title = "Choose song to upload";
            if (openFileDialog.ShowDialog() == DialogResult.OK) { 
                lbChooseFile.Text = "SELECTED";
                chooseFile = openFileDialog.FileName;
            }
        }

        public bool check()
        {
            string songName = txtSongName.Text;
            string singer = txtSinger.Text;
            if (songName == null || singer == null || chooseFile == null)
            {
                return false;
            }
            return true;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Please fill up all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string songName = txtSongName.Text;
            string singer = txtSinger.Text;
            int year = int.Parse(nudYear.Value.ToString());
            string target = "D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\";
            int size = songService.getALlSong().Count + 1;
            File.Copy(chooseFile, target + size + ".mp3");

            Song song = new Song(songName, singer, year, target + size + ".mp3"); 
            songService.save(song);
            MessageBox.Show("Upload song successfully", "Notification", MessageBoxButtons.OK);
            resetValue();
        }

        public void resetValue()
        {
            txtSongName.Text = "";
            txtSinger.Text = "";
            nudYear.Value = 2000;
            chooseFile = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }
    }
}
